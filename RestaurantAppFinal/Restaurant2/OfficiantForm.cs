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
    public partial class OfficiantForm : Form
    {
        public OfficiantForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-2AUO955\SQLEXPRESS; Initial Catalog=RestuarantDB; Integrated Security=true;");
        private Form _Form;
        private List<ProductItem> _ProductItemList=new List<ProductItem>();
        private string _OfficiantName = null;
        public OfficiantForm(Form form, string OfficiantName):this()
        {
            _Form = form;
            _OfficiantName = OfficiantName;
            FillDataGrid();
        }
        public void FillDataGrid()
        {
            sqlConnection.Open();
            string query = @"SELECT o.Name, o.Count, o.TotalPrice, t.TableNumber FROM Orders AS o
                            INNER JOIN Tables AS t ON t.Id=o.TableId
                            WHERE t.Officiant='" + _OfficiantName + "'";
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

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Form.Close();
        }

       
    }
}
