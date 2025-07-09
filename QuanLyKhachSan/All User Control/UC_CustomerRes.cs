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
    public partial class UC_CustomerRes : UserControl
    {
        private object txtPhone;

        public UC_CustomerRes()
        {
            InitializeComponent();
        }

        private void UC_CustomerRes_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Data Source=Ngoc\\SQLEXPRESS;Initial Catalog=dbMyHotel;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Insert 
                    string insertQuery = "INSERT INTO CheckOut (FullName, Phone, Nationality, Gender, DateOfBirth, IDProof, Address, CheckInDate, RoomNumber, RoomType, Bed, Price) " +
                                         "VALUES (@FullName, @Phone, @Nationality, @Gender, @DateOfBirth, @IDProof, @Address, @CheckInDate, @RoomNumber, @RoomType, @Bed, @Price)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);

                    cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhoneNo.Text);
                    cmd.Parameters.AddWithValue("@Nationality", txtNationality.Text);
                    cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", txtDob.Text);
                    cmd.Parameters.AddWithValue("@IDProof", txtIDProof.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CheckInDate", txtCheckin.Text);
                    cmd.Parameters.AddWithValue("@RoomNumber", txtRoomNo.Text);
                    cmd.Parameters.AddWithValue("@RoomType", txtRoomType.Text);
                    cmd.Parameters.AddWithValue("@Bed", txtBed.Text);
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Add customer successfully!");

                }
            }
            else
            {
                return;
            }

        }

        

        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

    }


}


