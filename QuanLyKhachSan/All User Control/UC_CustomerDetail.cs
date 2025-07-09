using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_CustomerDetail : UserControl
    {
        public UC_CustomerDetail()
        {
            InitializeComponent();
        }

        private void UC_CustomerDetail_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query1 = "SELECT * FROM CustomerDetail ";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string keyword = txtName.Text.Trim();

            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM CustomerDetail WHERE Name LIKE @keyword OR ID LIKE @keyword OR Username LIKE @keyword";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;

            }
        }
    }
}
