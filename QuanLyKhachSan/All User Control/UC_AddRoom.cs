using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    { 
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string connectionString = "Data Source=Ngoc\\SQLEXPRESS;DataBase=dbMyHotel;UID=userngoc;PWD=111111";
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();

            //string query = "SELECT * FROM KHACHHANG";
            //SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //dataGridView1.DataSource = dataTable;
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            //Kết nối CSDL
            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //Thêm giá trị cho comboAvailable
            comboAvailable.Items.Clear();
            comboAvailable.Items.Add("Yes");
            comboAvailable.Items.Add("No");
            comboAvailable.SelectedIndex = 0; // chọn mặc định là "Yes"

            string query1 = "SELECT * FROM Room";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            //clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            //UC_AddRoom_Load(this, null);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to add room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //Thực thi câu lệnh SQL query
            int ma=Int32.Parse(txtRoomNo.Text);
            string ten =txtRoomType.Text;
            string loai=txtBed.Text;
            int gia=Int32.Parse(txtPrice.Text);
            string available = comboAvailable.SelectedItem.ToString();

            string query = "insert into Room values ('"+Int32.Parse(txtRoomNo.Text)+"','"+ txtRoomType.Text + "','"+ txtBed.Text + "','"+ Int32.Parse(txtPrice.Text) + "', '"+available+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            string query1 = "SELECT * FROM Room";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //string query = "Update Room values ('" + Int32.Parse(txtRoomNo.Text) + "','" + txtRoomType.Text + "','" + txtBed.Text + "','" + Int32.Parse(txtPrice.Text) + "')";
            string query = "UPDATE Room SET RoomType='" + txtRoomType.Text + "',Bed='" + txtBed.Text + "',Price='" + txtPrice.Text + "' WHERE RoomNumber = '" + txtRoomNo.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            string query1 = "SELECT * FROM Room";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
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
            string query = "DELETE FROM Room WHERE RoomNumber='" + txtRoomNo.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();


            string query1 = "SELECT * FROM Room";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}




