using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class Machine_master : Form
    {
        public Machine_master()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Machine_master_Load(object sender, EventArgs e)
        {
            //lov value init bit_rate
            get_bitRate();
            get_parity();
            get_sBit();
            get_baud();
            get_comPort();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataBit_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void get_bitRate()
        {
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select val from machine_control where type='data_bit'", db_connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                dataBit_box.Items.Add(dr["val"].ToString());
            }
            db_connect.Close();
        }
        public void get_parity()
        {
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select val from machine_control where type='parity'", db_connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                paraty_box.Items.Add(dr["val"].ToString());
            }
            db_connect.Close();

        }
        public void get_sBit()
        {
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select val from machine_control where type='s_bit'", db_connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               stopBit_box.Items.Add(dr["val"].ToString());
            }
            db_connect.Close();

        }
        public void get_baud()
        {
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select val from machine_control where type='baud_rate'", db_connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                baudRate_box.Items.Add(dr["val"].ToString());
            }
            db_connect.Close();

        }
        public void get_comPort()
        {
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select val from machine_control where type='port'", db_connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               Portname_drop.Items.Add(dr["val"].ToString());
            }
            db_connect.Close();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            string qry = null;
            try
            {

                qry = "insert into machine_master(machine_id,prot_name, baud_rate, data_bit, parity, stop_bit) values('" + machineId_box.Text + "','" + Portname_drop.Text + "', '" + baudRate_box.Text + "', '" + dataBit_box.Text + "', '" + paraty_box.Text + "','" + stopBit_box.Text + "')";


                SqlCommand cmd = new SqlCommand(qry, db_connect);
                cmd.ExecuteNonQuery();

                db_connect.Close();
                MessageBox.Show("Device Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception" + ex);

            }
            finally
            {
                db_connect.Close();
            }

        }
    }
}
