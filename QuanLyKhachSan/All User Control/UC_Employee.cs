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

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        private string keyword;

        public UC_Employee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //Thực thi câu lệnh SQL query
            string query = "DELETE FROM Employee WHERE ID='" + txtID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Delete successfully!");


            string query1 = "SELECT * FROM Employee";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView2.DataSource = dt;
        }

        

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query1 = "SELECT * FROM Employee ";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView2.DataSource = dt;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
          
            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Employee (ID, Name, Phone, Gender, EmailID, Username, Password) " +
                               "VALUES (@ID, @Name, @Phone, @Gender, @EmailID, @Username, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@EmailID", txtEmailID.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                cmd.ExecuteNonQuery();
               
                MessageBox.Show("Sign up successfully!");
            }
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtID.Text.Trim();

            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Employee WHERE Name LIKE @keyword OR ID LIKE @keyword OR Username LIKE @keyword";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                guna2DataGridView2.DataSource = dt;

            }
        }

    }
}


