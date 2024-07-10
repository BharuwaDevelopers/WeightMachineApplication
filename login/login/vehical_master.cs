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
    public partial class vehical_master : Form
    {
        public vehical_master()
        {
            InitializeComponent();
        }

        private void Save_bttn_Click(object sender, EventArgs e)
        {
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            string qry = null;
            try
            {

                qry = "insert into f_vehicle(vehicle_no) values('" + vehicalno_box.Text + "')";

                SqlCommand cmd = new SqlCommand(qry, db_connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Save ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("exception "+ex);
            }
        }

        private void vehicalno_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                       Char.IsSeparator(e.KeyChar) ||
                       Char.IsSymbol(e.KeyChar);
        }
    }
}
