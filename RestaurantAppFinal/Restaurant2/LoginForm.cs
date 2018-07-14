using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FillRoles();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-2AUO955\SQLEXPRESS; Initial Catalog=RestuarantDB; Integrated Security=true;");

        public void FillRoles()
        {
            cmbx_roles.DataSource = Enum.GetNames(typeof(Role));
        }

        private Form _Form;
        public LoginForm(Form form ):this()
        {
            _Form = form;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string nameInput = txtbx_username.Text;
            string passwordInput = txtbx_password.Text;
            int roleIndex = cmbx_roles.SelectedIndex + 1;
            sqlConnection.Open();
            string query = @"SELECT s.Name, s.RoleId FROM Staff  as s 
                            WHERE s.Name='"+nameInput+"' AND Password='"+passwordInput+"' AND s.RoleId="+roleIndex;
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (!sqlDataReader.HasRows)
            {
                MessageBox.Show("Login failed");
                txtbx_username.Clear();
                txtbx_password.Clear();
            }

            while (sqlDataReader.Read())
            {
                if (roleIndex == 1)
                {
                    MessageBox.Show("Login is successful");
                    this.Hide();
                    OfficiantForm officiantForm = new OfficiantForm(this, txtbx_username.Text);
                    officiantForm.Show();
                }
                else if (roleIndex == 2)
                {
                    MessageBox.Show("Login is successful");
                    this.Hide();
                    ManagerForm managerForm = new ManagerForm(this);
                    managerForm.Show();
                }
                else
                {
                    MessageBox.Show("Login is successful");
                }
            }
            sqlConnection.Close();
            sqlCommand.Dispose();
            sqlDataReader.Close();

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Form.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm(this);
            registrationForm.Show();
        }
    }
}
