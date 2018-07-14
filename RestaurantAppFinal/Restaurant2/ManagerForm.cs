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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
       
        private Form _Form;
        public ManagerForm(Form form):this()
        {
            _Form = form;
            FillOfficiants();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-2AUO955\SQLEXPRESS; Initial Catalog=RestuarantDB; Integrated Security=true;");
        public void FillOfficiants()
        {
 
            sqlConnection.Open();
            string query = @"SELECT Name FROM Officiants";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Person officiant = new Person { };
                Name = sqlDataReader["Name"].ToString();
                combo_officiants.Items.Add(Name);
            }
            sqlConnection.Close();
            sqlCommand.Dispose();
            sqlDataReader.Close();

        }
        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Form.Close();
        }

        private void cmbx_officiants_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedOfficiantName = combo_officiants.SelectedItem.ToString();

            sqlConnection.Open();
            string query = @"SELECT o.Name, o.Count, o.TotalPrice, t.TableNumber FROM Orders AS o
                            INNER JOIN Tables AS t ON t.Id=o.TableId
                            WHERE t.Officiant='"+selectedOfficiantName+"'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<ProductItem> datasource = new List<ProductItem>();
            while (sqlDataReader.Read())
            {
                ProductItem productItem = new ProductItem
                {
                    Name = sqlDataReader["Name"].ToString(),
                    Count = Convert.ToByte(sqlDataReader["Count"].ToString()),
                    TotalPrice = Convert.ToDecimal(sqlDataReader["TotalPrice"].ToString())
                };
                datasource.Add(productItem);
            }
            dataGridOrders.DataSource = datasource;
            sqlConnection.Close();
            sqlDataReader.Close();
            sqlCommand.Dispose();
        }

        
    }
}
