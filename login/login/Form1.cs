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
using login.Serial;

namespace login
{
    public partial class Form1 : Form
    {
       public static String User_sessson;
        public static String Session_priv;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LISTNER lis = new LISTNER();
            lis.Show();
            lis.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from user_master where user_name='"+ username_box.Text +"' and password = '" + password_box.Text +"'",db_connect);
            SqlDataAdapter sda1 = new SqlDataAdapter("Select auth_type from user_master where user_name='" + username_box.Text + "' ", db_connect);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            sda.Fill(dt);
            sda1.Fill(dt1);
            //Console.WriteLine("value of auth%$#@"+dt1.Rows[0][0]);
            
           // MessageBox.Show(dt.Rows[0][0].ToString());
            
            if (dt.Rows[0][0].ToString() == "1")
            {
                Console.WriteLine("value of user session ##" +dt.Rows[0][0]);

                User_sessson = username_box.Text;
                Console.WriteLine("value of user session ##"+User_sessson);
                Session_priv = dt1.Rows[0][0].ToString();


                this.Hide();
                main main_form = new main();
                main_form.Show();

                            }
            else
            {
                MessageBox.Show("Please check Username & Password");


            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
}
