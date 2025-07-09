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
using QuanLyKhachSan.All_User_Control;

namespace QuanLyKhachSan
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            uC_Checkout1.Visible = false;
            uC_CustomerDetail1.Visible = false;
            uC_Employee1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnAddRoom.Left + 50;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCustomerRes.Left + 60; 
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCheckOut.Left + 60;
            uC_Checkout1.Visible = true;
            uC_Checkout1.BringToFront();
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCustomerDetail.Left + 60;
            uC_CustomerDetail1.Visible = true;
            uC_CustomerDetail1.BringToFront();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnEmployee.Left + 60;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void uC_CustomerRes1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Checkout1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
