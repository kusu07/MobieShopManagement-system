using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobieShopManagement_system
{
    internal class fuction
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-81NQEVVL\\KUSHAL1;Initial Catalog=mobileshop;User ID=sa;Password=123456";
            return con;
        }

        public DataSet GetData(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public void setdata(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("data proceed successfull", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public SqlDataReader getforcombo(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
         
            return sdr; 
            
        }

    }





}
