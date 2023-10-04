using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Automation.Language;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobieShopManagement_system.all_users
{
    public partial class uc_customers : UserControl
    {
        fuction fn = new fuction();
        string query;
        public uc_customers()
        {
            InitializeComponent();
        }


        public void setcombobox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getforcombo(query);//select model from new mobile 
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }



        private void uc_customers_Enter(object sender, EventArgs e)
        {
            txt_company.Items.Clear();
            query = "select distinct cname from newmobile";
            setcombobox(query, txt_company);
        }

        private void txt_company_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_model.Items.Clear();
            string cname = txt_company.Text;
            query = "select mname from newmobile where cname ='" + cname + "'";
            setcombobox(query, txt_model);
        }

        private void txt_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from newmobile where mname='" + txt_model.Text + "'";
            DataSet ds = fn.GetData(query);
            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            explabel.Text = ds.Tables[0].Rows[0][5].ToString();
            backlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            frontlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            fingerlabel.Text = ds.Tables[0].Rows[0][9].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][12].ToString();
        }
        private void btn_purchase_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string gender = txt_gender.Text;
            Int64 contact = Int64.Parse(txt_contactno.Text);
        }

    }
}

