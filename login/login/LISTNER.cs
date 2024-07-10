using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  login;
using System.IO;
using System.Data.SqlClient;

namespace login.Serial
{
    public partial class LISTNER : Form
       {
        public static string a;
        public static String ld_data = "0";
        public static string active_mech;
        SerialPortManager _spManager;   
        public LISTNER()
        {
            InitializeComponent();
            UserInitialization();
        }

        private void UserInitialization()
        {
            _spManager = new SerialPortManager();
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
            //serialSettingsBindingSource.DataSource = mySerialSettings;
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            SqlDataAdapter sda = new SqlDataAdapter("Select * from machine_master where m_status = 'Active' ", db_connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Console.WriteLine("mechine master is @@###" + dt.Rows[0][1]) ;
            Console.WriteLine("mechine master is @@###" + dt.Rows[0][2]);
            Console.WriteLine("mechine master is @@###" + dt.Rows[0][3]);
            Console.WriteLine("mechine master is @@###" + dt.Rows[0][4]);
            Console.WriteLine("mechine master is @@###" + dt.Rows[0][5]);
            string stop_bit = dt.Rows[0][5].ToString().Trim();
            portNameComboBox.Text = dt.Rows[0][1].ToString().Trim();
            baudRateComboBox.Text = dt.Rows[0][2].ToString().Trim();
            dataBitsComboBox.Text = dt.Rows[0][3].ToString().Trim();
            parityComboBox.Text = dt.Rows[0][4].ToString().Trim();
            stopBitsComboBox.Text = dt.Rows[0][5].ToString().Trim();
            //portNameComboBox.Text = "COM4";
            //baudRateComboBox.Text = "9600";
            //dataBitsComboBox.Text = "8";
            //parityComboBox.Text = "None";
            //stopBitsComboBox.Text = "0";





           
            //portNameComboBox.DataSource = mySerialSettings.PortNameCollection;
           // baudRateComboBox.DataSource = mySerialSettings.BaudRateCollection;
            //dataBitsComboBox.DataSource = mySerialSettings.DataBitsCollection;
            //parityComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.Parity));
            //stopBitsComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.StopBits));

            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _spManager.Dispose();
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
        //        this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
        //        return;
        //    }
        //    //Console.WriteLine("value of is *&^" + e.Data);
        //    int maxTextLength = 1000; // maximum text length in text box
        //    //if (tbData1.TextLength > maxTextLength)
        //    //    tbData1.Text = tbData1.Text.Remove(0, tbData1.TextLength - maxTextLength);


        //    // This application is connected to a GPS sending ASCCI characters, so data is converted to text
        //    string str = e.strData;
        //    string newstr = " ";

        //    textBox1.Text = str;
        //    if (str.ToLower().Contains("k   "))
        //    {
        //        if (str.IndexOf("k", str.IndexOf("k   ") + 1) > 0)
        //            newstr = str.Substring(str.IndexOf("k   ") + 4, str.IndexOf("k", str.IndexOf("k   ") + 1) - (str.IndexOf("k   ") + 4)).Trim();
        //        else
        //            newstr = str.Substring(str.IndexOf("k   ") + 4).Trim();
        //    }
        //    else
        //    {
        //        newstr = str.Trim();
        //    }
        //    Console.WriteLine("str" + e.strData);
        //    Console.WriteLine("newstr" + newstr);

        //    // textBox1.Text = newstr.ToString();
        //    tbData1.Text = newstr;

        //}

        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
        {
            try { 
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }
            Console.WriteLine("value of is *&^" + e.Data);
            int maxTextLength = 1000; // maximum text length in text box
            if (tbData1.TextLength > maxTextLength)
                tbData1.Text = tbData1.Text.Remove(0, tbData1.TextLength - maxTextLength);


            // This application is connected to a GPS sending ASCCI characters, so data is converted to text
            string str = Encoding.ASCII.GetString(e.Data);
            string newstr;

            textBox1.Text = str;
                //paste hare 

                if (str.ToLower().Contains(" "))
                {
                    Console.WriteLine("value of first" + str.Substring(str.IndexOf(" ") + 1).Length);
                    if (str.Substring(str.IndexOf(" ") + 1).Length > 6)
                    {
                        newstr = str.Substring(str.IndexOf(" ") + 1, 6).Trim();
                        //Console.WriteLine("value of str" + str.IndexOf(" "));
                    }
                    else
                    {
                        newstr = str.Substring(str.IndexOf("") + 1).Trim();
                        // Console.WriteLine("value%%"+ str.IndexOf(""));
                    }
                }
                else
                {
                    newstr = str.Trim();
                }
                //Console.WriteLine("value of str" +newstr

                //if (str.ToLower().Contains("0"))
                //{
                //    Console.WriteLine("value of first" + str.Substring(str.IndexOf(" ") + 1).Length);
                //    if (str.Substring(str.IndexOf(" ") + 1).Length > 6)
                //    {
                //        newstr = str.Substring(str.IndexOf(" ") + 1, 6).Trim();
                //    }
                //    else
                //    {
                //        newstr = str.Substring(str.IndexOf("") + 1).Trim();
                //    }
                //}
                //else
                //{
                //    newstr = str.Trim();
                //}



                //if (str.ToLower().Contains("k"))
                //{
                //    if (str.Substring(str.IndexOf("k") + 1).Length > 7)
                //    {
                //        newstr = str.Substring(str.IndexOf("k") + 1, 7).Trim();
                //    }
                //    else
                //    {
                //        newstr = str.Substring(str.IndexOf("k") + 1).Trim();
                //    }
                //}
                //else
                //{
                //    newstr = str.Trim();
                //}

                Console.WriteLine("str" + e.strData);
            Console.WriteLine("newstr" + newstr);


            // textBox1.Text = newstr.ToString();
            ld_data = newstr;

            tbData1.Text = newstr;
            // main main = new main();
            // main.crr_weight(newstr);
            //tbData1.Text = RandomString(5);
            //String newstr1 = " ";
            //if (tbData1.Text.ToLower().Contains("k   "))
            //{
            //    if (tbData1.Text.IndexOf("k", str.IndexOf("k   ") + 1) > 0)
            //        newstr = tbData1.Text.Substring(str.IndexOf("k   ") + 4, tbData1.Text.IndexOf("k", tbData1.Text.IndexOf("k   ") + 1) - (tbData1.Text.IndexOf("k   ") + 4)).Trim();
            //    else
            //        newstr1 = tbData1.Text.Substring(tbData1.Text.IndexOf("k   ") + 4).Trim();
            //}
            //else
            //{
            //    newstr1 = str;
            //}
            //// tbData1.Text = str;

            ////tbData1.ScrollToCaret();
            //textBox1.Text = newstr1; 
        }
            catch (Exception EX)
            {
                MessageBox.Show("exception"+EX);
            }
        }

        // Handles the "Start Listening"-buttom click event
        private void btnStart_Click(object sender, EventArgs e)
        {
           
            Console.WriteLine("value of aaaa###" + a);
           


        }

        // Handles the "Stop Listening"-buttom click event
        private void btnStop_Click(object sender, EventArgs e)
        {
            _spManager.StopListening();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void LISTNER_Load(object sender, EventArgs e)
        {
            //this.Hide();
            try
            {
                string m_status = "Active";
                SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
                db_connect.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from machine_master where m_status='" + m_status + "' ", db_connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Console.WriteLine(dt.Rows[0][0]);
                active_mech = dt.Rows[0][0].ToString();
                Console.WriteLine(dt.Rows[0][1]);
                Console.WriteLine(dt.Rows[0][2]);
                Console.WriteLine(dt.Rows[0][3]);
                Console.WriteLine(dt.Rows[0][4]);
                Console.WriteLine(dt.Rows[0][5]);
                db_connect.Close();
            }

            catch(Exception EX)
            {
                MessageBox.Show("EX"+EX);
            }
            //_spManager.StartListening();

         _spManager.StartListening();
           

        }

      
        private void serialSettingsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbData_KeyUp(object sender, KeyEventArgs e)
        {
        
        }

        private void portNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
