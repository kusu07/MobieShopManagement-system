using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobieShopManagement_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnexist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            uc_add_new_phone1.Visible = false;
            uc_customers1.Visible = false;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            uc_add_new_phone1.Visible = true;
            uc_add_new_phone1.BringToFront();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            uc_customers1.Visible = true;
            uc_customers1.BringToFront();
        }
    }
}
