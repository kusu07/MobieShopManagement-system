using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobieShopManagement_system.all_users
{

    public partial class uc_add_new_phone : UserControl
    {
        fuction fn = new fuction();
        string query;

        public uc_add_new_phone()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_company.Text!="" && txt_modelno.Text!="" && txt_ram.Text!=""&& txt_internalstorage.Text !="" && txt_expmemory.Text!="" && txt_display.Text!="" && txt_backcamera.Text!="" && txt_frontcamera.Text!="" && txt_fingerprintsens.Text!="" && txt_simtype.Text!=""&& txt_networktype.Text!=""&& txt_price.Text!="" )
            { 
                string company = txt_company.Text;
                string modelno = txt_modelno.Text;
                string ram = txt_ram.Text;
                string storage = txt_internalstorage.Text;
                string expandable = txt_expmemory.Text;
                string display = txt_display.Text;
                string back = txt_backcamera.Text;
                string front = txt_frontcamera.Text;
                string finger = txt_fingerprintsens.Text;
                string sim = txt_simtype.Text;
                string network = txt_networktype.Text;
                Int64 price = Int64.Parse(txt_price.Text);

                query = "insert into newmobile(cname,mname,ram,internal,expandable,display,back,front,finger,sim,network,price) values ('" + company + "','" + modelno + "','" + ram + "','" + storage + "','" + expandable + "','" + display + "','" + back + "','" + front + "','" + finger + "','" + sim + "','" + network + "'," + price + ")";
                fn.setdata(query);

            }
            else
            {
                MessageBox.Show(" Fill all data","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_company.Clear();
            txt_modelno.Clear();
            txt_ram.StartIndex = -1;
            txt_internalstorage.StartIndex = -1;
            txt_expmemory.StartIndex = -1;
            txt_display.StartIndex = -1;
            txt_backcamera.StartIndex = -1;
            txt_frontcamera.StartIndex = -1;
            txt_fingerprintsens.StartIndex = -1;
            txt_simtype.StartIndex = -1;
            txt_networktype.StartIndex = -1;
            txt_price.Clear();
        }
    }
}
