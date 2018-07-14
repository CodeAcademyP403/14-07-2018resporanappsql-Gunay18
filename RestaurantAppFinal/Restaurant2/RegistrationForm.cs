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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            FillRoles();
        }

        public void FillRoles()
        {
            cmbx_roles.DataSource = Enum.GetNames(typeof(Role));
        }

        private Form _Form;
     
        public RegistrationForm(Form form) :this()
        {
            _Form = form;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            //Adds new person to Staff Table
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-2AUO955\SQLEXPRESS; Initial Catalog=RestuarantDB; Integrated Security=true;");
            sqlConnection.Open();
            int roleId = cmbx_roles.SelectedIndex+1;
            string query = @"INSERT INTO Staff(Name, Email, Password, RoleId)
                            VALUES ('"+txtbx_name.Text +"','" + txtbx_email.Text+"','"+ txtbx_password.Text+"'," +roleId+")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            sqlConnection.Close();


            LoginForm loginForm = new LoginForm(this);
            this.Hide();
            loginForm.Show();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Form.Close();
        }
    }
}
