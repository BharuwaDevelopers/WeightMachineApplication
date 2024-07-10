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
    public partial class User_Master : Form
    {
        public User_Master()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 

            userid_box.Text =  gen_userid().ToString();
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            string qry = null;
            try
            {
               
                qry = "insert into user_master(Id,User_name,password,auth_type) values('" + int.Parse(userid_box.Text) + "','" + userName_box.Text + "', '" + password_box.Text + "','" + User_priv_drop.Text + "')";


                SqlCommand cmd = new SqlCommand(qry, db_connect);
                cmd.ExecuteNonQuery();
                db_connect.Close();
                MessageBox.Show("User Created");
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

        private void User_Master_Load(object sender, EventArgs e)
        {
           // User_priv_drop.Items.Add["Admin"];
        }
        public int gen_userid()
        {
            int seq = 0;
            try
            {

                SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
                SqlDataAdapter sda = new SqlDataAdapter("Select max(id) from user_master ", db_connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                if (dt.Rows[0][0].ToString() == "")
                {
                    seq = 10001;
                   
                }
                else
                {
                    Console.WriteLine("walue of gen id is " + dt.Rows[0][0]);
                    seq = int.Parse(dt.Rows[0][0].ToString());
                    seq = ++seq;
                    //seq++;
                    Console.WriteLine("walue of seq " + seq);
                    
                }
                    db_connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exceprion "+ex);
            }
            return seq;
           
        }

    }
}
