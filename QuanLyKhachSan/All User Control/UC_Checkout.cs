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
    public partial class UC_Checkout : UserControl
    {
        public UC_Checkout()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_Checkout_Load(object sender, EventArgs e)
        {
            //Kết nối CSDL
            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();



            string query1 = "SELECT * FROM CheckOut ";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            MessageBox.Show("Check out successfully!");


            string query1 = "SELECT * FROM CheckOut";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
    

