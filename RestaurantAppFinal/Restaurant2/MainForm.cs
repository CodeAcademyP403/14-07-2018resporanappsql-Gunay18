using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace Restaurant2
{
    public partial class MainForm : Form
    {
        
        private List<Product> products = new List<Product>();
        private List<string> categories = new List<string>();
        private List<ProductItem> productItems = new List<ProductItem>();


        public MainForm()
        {
            InitializeComponent();

            LoadOfficiants();
            LoadCategory();
            LoadProducts();
            setMenuInvisible();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-2AUO955\SQLEXPRESS; Initial Catalog=RestuarantDB; Integrated Security=true;");
       
        public void LoadCategory()
        {
            try
            {
                sqlConnection.Open();

                string query = @"SELECT fc.CategoryName FROM FoodCategories AS fc";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    categories.Add(sqlDataReader["CategoryName"].ToString());
                }
               cmbx_category.DataSource=categories;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void LoadProducts()
        {
            try
            {
                sqlConnection.Open();
                string query = @"SELECT f.FoodName, f.Price, f.CategoryID FROM Food as f;";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Product product = new Product
                    {
                        Name = sqlDataReader["FoodName"].ToString(),
                        Price = Convert.ToDecimal(sqlDataReader["Price"].ToString()),
                        CategoryId = Convert.ToInt32(sqlDataReader["CategoryID"].ToString())
                    };
                    products.Add(product);
                }
                sqlCommand.Dispose();
                sqlDataReader.Close();
                sqlConnection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void setMenuInvisible()
        {
            cmbx_category.Visible = false;
            cmbx_name.Visible = false;
            lbl_price.Visible = false;
            lbl_name.Visible = false;
            lbl_category.Visible = false;
            label3.Visible = false;
            lbl_count.Visible = false;
            txtbx_count.Visible = false;
            txtbx_price.Visible = false;
            btn_order.Visible = false;
            btnComplete.Visible = false;
        }

        public void setMenuVisible()
        {
            cmbx_category.Visible = true;
            cmbx_name.Visible = true;
            lbl_price.Visible = true;
            lbl_name.Visible = true;
            lbl_category.Visible = true;
            label3.Visible = true;
            lbl_count.Visible = true;
            txtbx_count.Visible = true;
            txtbx_price.Visible = true;
            btn_order.Visible = true;
            btnComplete.Visible = true;
        }

        public void LoadOfficiants()
        {
            sqlConnection.Open();
            string query = @"SELECT o.Name FROM Officiants AS o;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                string officiant = sqlDataReader["Name"].ToString();
                cmbx_officiants.Items.Add(officiant);
            }
            sqlConnection.Close();
            sqlCommand.Dispose();
            sqlDataReader.Close();
        }

        private decimal Sum = 0;
        private void btn_order_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            sqlConnection.Open();
            string name = cmbx_name.SelectedItem.ToString();
            byte count = Convert.ToByte(txtbx_count.Text);
            decimal price = Convert.ToDecimal(txtbx_price.Text);
            decimal totalPrice = count * price;
            int tableId = 0;

            string intermediaryQuery = @"SELECT TOP 1 Id FROM tables ORDER BY Id DESC";
            SqlCommand command = new SqlCommand(intermediaryQuery, sqlConnection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                tableId =Convert.ToInt32(sqlDataReader["Id"].ToString());
            }
            sqlDataReader.Close();
            command.Dispose();

            string query = @"INSERT INTO Orders(Name, Count, TotalPrice, TableId)
                           VALUES ('" + name+"',"+count+","+totalPrice+","+tableId+")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
           
            ProductItem productItem = new ProductItem()
            {
                Name=name,
                Count=count,
                TotalPrice=totalPrice
            };
            productItems.Add(productItem);
            dataGrid.DataSource = null;
            dataGrid.DataSource = productItems;
            Sum += productItem.TotalPrice;
            lbl_price.Text = Sum.ToString();
           
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            int nextTableNumber = Convert.ToInt32(txbx_table.Text)+1;
            txbx_table.Text = nextTableNumber.ToString();

            cmbx_category.SelectedIndex = 0;
            cmbx_name.SelectedIndex = 0;
            txtbx_count.Text = "1";
            txtbx_price.Text = "";
            dataGrid.DataSource = null;
            btn_start.Visible = true;
            cmbx_officiants.Enabled = true;
        }


        private void cmbx_name_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmbx_name.SelectedItem != null)
            {
                foreach (Product item in products)
                {
                    if (item.Name == cmbx_name.SelectedItem.ToString())
                    {
                        txtbx_price.Text = item.Price.ToString();
                    }
                }
            }
           
        }

        private void btn_logadmin_Click(object sender, EventArgs e)
        {
            //sending MainForm into LoginForm, so that when LoginForm closes, it closes MainForm too
            LoginForm loginForm = new LoginForm(this);
            this.Hide();
            loginForm.Show();
            
        }

        private void cmbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_category.SelectedIndex!=-1)
            {
                int selectedIndex = cmbx_category.SelectedIndex+1;
                cmbx_name.Items.Clear();
                txtbx_price.Clear();
                foreach (Product product in products)
                {
                    if (selectedIndex==product.CategoryId)
                    {
                        cmbx_name.Items.Add(product.Name);
                    }
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            int tableNumber = Convert.ToInt32(txbx_table.Text);
            string officiant = cmbx_officiants.SelectedItem.ToString();
            string query = @"INSERT INTO Tables
                            (TableNumber, Officiant)
                            VALUES("+tableNumber+",'"+officiant+"')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            setMenuVisible();
            btn_start.Visible = false;
            cmbx_officiants.Enabled = false;
        }

    }
}
