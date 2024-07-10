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
    public partial class Charges_Master : Form
    {
        public Charges_Master()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void save_but_Click(object sender, EventArgs e)
        {
            string qry = null;
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            qry = "insert into charge_master(tyre,charges) values('" + tareM_box.Text + "','" +chargesM_box.Text + "')";

            SqlCommand cmd = new SqlCommand(qry, db_connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Save");
            db_connect.Close();
        }
    }
}
