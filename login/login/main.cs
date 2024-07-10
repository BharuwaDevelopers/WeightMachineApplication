using login.Serial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Threading;
using NPOI.SS.Util;
using System.Text.RegularExpressions;


namespace login
{
    public partial class main : Form
    {
        string weight_chk1;
        string weight_chk2;
        public static string b;
        public static string cr_date;
        public static string prn_slipno;
        public static string prn_partyname;
        public static string prn_vehicle_type;
        public static string prn_charges;
        public static string prn_op_name;
        public static string prn_t_weight;
        public static string prn_g_weight;
        public static string prn_n_weight;
        public static string prn_product;
        public static string t_no;
        public static string mdate;
        public static string veh_no;
        public string watermark = null;


        public System.Drawing.Printing.PageSettings PageSettings { get; set; }


        public main()
        {


            InitializeComponent();

            // b = LISTNER.load_data;

            new Thread(crr_weight).Start();
            //weight_box.Text = b;


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public static void SendToMain(string a)
        {

            //b = LISTNER.a;
            //weight_box.Text = b;
            b = LISTNER.load_data;
            b = LISTNER.load_data;



        }
        void main_Load(object sender, EventArgs e)
        {

            get_tyer();
            get_charges();
            User_priv();
            new Thread(crr_weight).Start();



        }



        private void weight_box_TextChanged(object sender, EventArgs e)
        {


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void save_main_Click_old(object sender, EventArgs e)

        {

            // Console.WriteLine("value of nullees@!@!@" + dt.Rows[0][0]);

            //if (String.IsNullOrEmpty(weight_box.Text) && String.IsNullOrEmpty(tire_weight_box.Text))
            //{
            //    MessageBox.Show("Tare Weight Or Gross Weight Should Not Be Empty");
            //}
            if (String.IsNullOrEmpty(Vehical_box.Text))
            {
                MessageBox.Show("Please Enter Vehical No");
            }

            if (String.IsNullOrEmpty(slipno_box.Text))
            {
                Console.WriteLine("value of vechlbox%^&*" + Vehical_box.Text);
                SqlConnection db_connect1 = new SqlConnection(db_Connection.connection_string());
                SqlDataAdapter sda = new SqlDataAdapter("Select net_weight,slip_no from measure where vehical_no ='" + Vehical_box.Text.Trim() + "' and net_weight = '' or net_weight = 'NULL' ", db_connect1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Pending Slip against vehiclenom " + Vehical_box.Text + " slip no " + dt.Rows[0][1]);
                }
                else
                {
                    SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
                    db_connect.Open();
                    string qry = null;
                    if (String.IsNullOrEmpty(slipno_box.Text))
                    {

                        // slip no gen
                        string mrg = " ";
                        String active_m = LISTNER.active_mech.Trim();
                        string dt_chk = get_slipseq().Substring(2, 6);
                        Console.WriteLine("valueo f dtchk##" + dt_chk);
                        string kk = get_slipseq().Substring(8);
                        string gen_slipno = "";
                        Console.WriteLine("KK VALUE@@@@" + kk);
                        int slipseq = int.Parse(kk);
                        slipseq++;
                        var slipseqdate = DateTime.Now.ToString("yyMMdd");
                        // compair db date and current date
                        if (int.Parse(dt_chk) != int.Parse(slipseqdate))
                        {
                            slipseq = 1;
                            kk = "0";
                            mrg = "000" + slipseq.ToString();
                            gen_slipno = active_m + slipseqdate + mrg;
                        }
                        else
                        {

                            if (int.Parse(kk) < 10)
                            {
                                mrg = "000" + slipseq.ToString();

                                gen_slipno = active_m + slipseqdate + mrg;
                            }
                            if (int.Parse(kk) > 9 && int.Parse(kk) < 99)
                            {
                                mrg = "00" + slipseq.ToString();

                                gen_slipno = active_m + slipseqdate + mrg;
                            }
                            if (int.Parse(kk) > 99 && int.Parse(kk) < 999)
                            {
                                mrg = "0" + slipseq.ToString();

                                gen_slipno = active_m + slipseqdate + mrg;
                            }
                            if (int.Parse(kk) > 999 && int.Parse(kk) < 9999)
                            {
                                gen_slipno = active_m + slipseqdate + slipseq;

                            }
                        }
                        //halt after 99999
                        if (slipseq > 9999)
                        {

                            MessageBox.Show("Max Slip No is 9999");
                            this.Close();

                        }
            ;






                        MessageBox.Show(gen_slipno);

                        //int? gross_weight = int.Parse(weight_box.Text.ToString());
                        //int? tare_weight = int.Parse(tire_weight_box.Text.ToString());

                        string get_session = Form1.User_sessson.ToString();

                        try
                        {


                            //string slip_no = slipno_box.Text.ToString();
                            //string weigh = weight_box.Text.ToString();
                            int? net_weight = null;



                            DateTime curr_date = DateTime.Now;
                            string StringFormat = "yyy-MM-dd HH:MM:ss";

                            string ss = curr_date.ToString(StringFormat);
                            date_box.Text = ss;

                            Console.WriteLine("Date*&*&**" + ss);

                            slipno_box.Text = gen_slipno.ToString();
                            qry = "insert into measure(slip_no, weight, tire_weight, net_weight, vehical_no, party, meterial, vehical_type, charges, date,remarks, user_name,token_no) values('" + gen_slipno + "','" + weight_box.Text + "', '" + tire_weight_box.Text + "', '" + net_weight + "',  '" + Vehical_box.Text + "', '" + Party_box.Text + "', '" + meterial_box.Text + "','" + vechaltype_drop.Text + "','" + charges_drop.Text + "','" + curr_date.ToString(StringFormat) + "', '" + remarks_box.Text + "','" + get_session + "','" + tokenNo_box.Text + "')";
                            String slipchkqry = ("Select net_weight from measure where  ='" + Vehical_box.Text + "' and net_weight = '' or net_weight = 'NULL'; ");

                            SqlCommand cmd = new SqlCommand(qry, db_connect);
                            cmd.ExecuteNonQuery();



                            // MessageBox.Show("data save");

                            db_connect.Close();
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

            else
            {

                
                //try
                //{

                //to update slip no 
                DateTime curr_date = DateTime.Now;
                string StringFormat = "yyy-MM-dd HH:MM:ss";

                string ss = curr_date.ToString(StringFormat);
                mod_date.Text = ss.ToString();
                Console.WriteLine("net%%#%#%#" + ss);
                mod_date.Text = ss.ToString();

                int net_weight = int.Parse(weight_box.Text) - int.Parse(tire_weight_box.Text);

                net_weight_box.Text = net_weight.ToString();

                SqlConnection db_connect_1 = new SqlConnection(db_Connection.connection_string());


                db_connect_1.Open();

                SqlCommand SqlComm = new SqlCommand("UPDATE measure SET weight=@weight , tire_weight=@tire_weight, net_weight=@net_weight ,  party=@party , meterial=@meterial , vehical_type=@vehical_type , charges=@charges , date=@date , remarks=@remarks, mod_date=@mod_date , mod_by=@mod_by  where slip_no=@slip_no", db_connect_1);
                Console.WriteLine("DB CONNECT " + db_connect_1);

                SqlComm.Parameters.AddWithValue("@weight", weight_box.Text);
                SqlComm.Parameters.AddWithValue("@tire_weight", tire_weight_box.Text);
                SqlComm.Parameters.AddWithValue("@net_weight", net_weight.ToString());
                // SqlComm.Parameters.AddWithValue("@vehical_no", Vehical_box.Text);
                SqlComm.Parameters.AddWithValue("@party", Party_box.Text);
                SqlComm.Parameters.AddWithValue("@meterial", meterial_box.Text);
                SqlComm.Parameters.AddWithValue("@vehical_type", vechaltype_drop.Text);
                SqlComm.Parameters.AddWithValue("@charges", charges_drop.Text);
                SqlComm.Parameters.AddWithValue("@date", date_box.Text);

                SqlComm.Parameters.AddWithValue("@remarks", remarks_box.Text);

                SqlComm.Parameters.AddWithValue("@mod_date", ss.ToString());
                SqlComm.Parameters.AddWithValue("@mod_by", Form1.User_sessson.ToString());
                SqlComm.Parameters.AddWithValue("@slip_no", slipno_box.Text);

                SqlComm.ExecuteNonQuery();
                db_connect_1.Close();
                MessageBox.Show("Slip no Updated");



            }
        }


        private void save_main_Click(object sender, EventArgs e)

        {

            // Console.WriteLine("value of nullees@!@!@" + dt.Rows[0][0]);

            //if (String.IsNullOrEmpty(weight_box.Text) && String.IsNullOrEmpty(tire_weight_box.Text))
            //{
            //    MessageBox.Show("Tare Weight Or Gross Weight Should Not Be Empty");
            //}
            if (String.IsNullOrEmpty(Vehical_box.Text))
            {
                MessageBox.Show("Please Enter Vehical No");
            }

            if (String.IsNullOrEmpty(slipno_box.Text))
            {
                Console.WriteLine("value of vechlbox%^&*" + Vehical_box.Text);
                SqlConnection db_connect1 = new SqlConnection(db_Connection.connection_string());
                SqlDataAdapter sda = new SqlDataAdapter("Select net_weight,slip_no from measure where vehical_no ='" + Vehical_box.Text.Trim() + "' and net_weight = '' or net_weight = 'NULL' ", db_connect1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Pending Slip against vehiclenom " + Vehical_box.Text + " slip no " + dt.Rows[0][1]);
                }
                else
                {
                    SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
                    db_connect.Open();
                    string qry = null;
                    if (String.IsNullOrEmpty(slipno_box.Text))
                    {

                        // slip no gen
                        string mrg = " ";
                        String active_m = LISTNER.active_mech.Trim();
                        string dt_chk = get_slipseq().Substring(2, 6);
                        Console.WriteLine("valueo f dtchk##" + dt_chk);
                        string kk = get_slipseq().Substring(8);
                        string gen_slipno = "";
                        Console.WriteLine("KK VALUE@@@@" + kk);
                        int slipseq = int.Parse(kk);
                        slipseq++;
                        var slipseqdate = DateTime.Now.ToString("yyMMdd");
                        // compair db date and current date
                        if (int.Parse(dt_chk) != int.Parse(slipseqdate))
                        {
                            slipseq = 1;
                            kk = "0";
                            mrg = "000" + slipseq.ToString();
                            gen_slipno = active_m + slipseqdate + mrg;
                        }
                        else
                        {

                            if (slipseq < 10)
                            {
                                mrg = "000" + slipseq.ToString();

                                gen_slipno = active_m + slipseqdate + mrg;
                            }
                            if (slipseq > 9 && slipseq < 100)
                            {
                                mrg = "00" + slipseq.ToString();

                                gen_slipno = active_m + slipseqdate + mrg;
                            }
                            if (slipseq > 99 && slipseq < 1000)
                            {
                                mrg = "0" + slipseq.ToString();

                                gen_slipno = active_m + slipseqdate + mrg;
                            }
                            if (slipseq > 999 && slipseq < 9999)
                            {
                                gen_slipno = active_m + slipseqdate + slipseq;

                            }
                        }
                        //halt after 99999
                        if (slipseq > 9999)
                        {

                            MessageBox.Show("Max Slip No is 9999");
                            this.Close();

                        }
            ;






                        MessageBox.Show(gen_slipno);

                        //int? gross_weight = int.Parse(weight_box.Text.ToString());
                        //int? tare_weight = int.Parse(tire_weight_box.Text.ToString());

                        string get_session = Form1.User_sessson.ToString();

                        try
                        {


                            //string slip_no = slipno_box.Text.ToString();
                            //string weigh = weight_box.Text.ToString();
                            int? net_weight = null;



                            DateTime curr_date = DateTime.Now;
                            string StringFormat = "yyy-MM-dd HH:MM:ss";

                            string ss = curr_date.ToString(StringFormat);
                            date_box.Text = ss;

                            Console.WriteLine("Date*&*&**" + ss);

                            slipno_box.Text = gen_slipno.ToString();
                            qry = "insert into measure(slip_no, weight, tire_weight, net_weight, vehical_no, party, meterial, vehical_type, charges, date,remarks, user_name,token_no) values('" + gen_slipno + "','" + weight_box.Text + "', '" + tire_weight_box.Text + "', '" + net_weight + "',  '" + Vehical_box.Text + "', '" + Party_box.Text + "', '" + meterial_box.Text + "','" + vechaltype_drop.Text + "','" + charges_drop.Text + "','" + curr_date.ToString(StringFormat) + "', '" + remarks_box.Text + "','" + get_session + "','" + tokenNo_box.Text + "')";
                            String slipchkqry = ("Select net_weight from measure where  ='" + Vehical_box.Text + "' and net_weight = '' or net_weight = 'NULL'; ");

                            SqlCommand cmd = new SqlCommand(qry, db_connect);
                            cmd.ExecuteNonQuery();



                            // MessageBox.Show("data save");

                            db_connect.Close();
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

            else
            {


                //try
                //{

                //to update slip no 
                DateTime curr_date = DateTime.Now;
                string StringFormat = "yyy-MM-dd HH:MM:ss";

                string ss = curr_date.ToString(StringFormat);
                mod_date.Text = ss.ToString();
                Console.WriteLine("net%%#%#%#" + ss);
                mod_date.Text = ss.ToString();

                int net_weight = int.Parse(weight_box.Text) - int.Parse(tire_weight_box.Text);

                net_weight_box.Text = net_weight.ToString();

                SqlConnection db_connect_1 = new SqlConnection(db_Connection.connection_string());


                db_connect_1.Open();

                SqlCommand SqlComm = new SqlCommand("UPDATE measure SET weight=@weight , tire_weight=@tire_weight, net_weight=@net_weight ,  party=@party , meterial=@meterial , vehical_type=@vehical_type , charges=@charges , date=@date , remarks=@remarks, mod_date=@mod_date , mod_by=@mod_by  where slip_no=@slip_no", db_connect_1);
                Console.WriteLine("DB CONNECT " + db_connect_1);

                SqlComm.Parameters.AddWithValue("@weight", weight_box.Text);
                SqlComm.Parameters.AddWithValue("@tire_weight", tire_weight_box.Text);
                SqlComm.Parameters.AddWithValue("@net_weight", net_weight.ToString());
                // SqlComm.Parameters.AddWithValue("@vehical_no", Vehical_box.Text);
                SqlComm.Parameters.AddWithValue("@party", Party_box.Text);
                SqlComm.Parameters.AddWithValue("@meterial", meterial_box.Text);
                SqlComm.Parameters.AddWithValue("@vehical_type", vechaltype_drop.Text);
                SqlComm.Parameters.AddWithValue("@charges", charges_drop.Text);
                SqlComm.Parameters.AddWithValue("@date", date_box.Text);

                SqlComm.Parameters.AddWithValue("@remarks", remarks_box.Text);

                SqlComm.Parameters.AddWithValue("@mod_date", ss.ToString());
                SqlComm.Parameters.AddWithValue("@mod_by", Form1.User_sessson.ToString());
                SqlComm.Parameters.AddWithValue("@slip_no", slipno_box.Text);

                SqlComm.ExecuteNonQuery();
                db_connect_1.Close();
                MessageBox.Show("Slip no Updated");



            }
        }


        private void populate_Click(object sender, EventArgs e)
        {

        }

        private void weight_box_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {


            b = LISTNER.ld_data.ToString();


            if (weight_chk1 == "True")
            {
                tire_weight_box.Text = (int.Parse(b)).ToString();
                // weight_box.Clear();
            }
            if (weight_chk2 == "True")
            {
                weight_box.Text = (int.Parse(b)).ToString();
                // tire_weight_box.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //new Thread(crr_weight).Abort();
            //this.Close();
            Application.Exit();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tireMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            weight_chk1 = radioButton1.Checked.ToString();
            //MessageBox.Show("radiobutton" + weight_chk1);
            //Console.WriteLine("######value of radio########"+weight_chk1);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            weight_chk2 = radioButton2.Checked.ToString();
            // MessageBox.Show("radiobutton2" + weight_chk2);
        }

        private void slipno_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void slipno_box_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //MessageBox.Show("Press Enter");
                    SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
                    SqlDataAdapter sda = new SqlDataAdapter("Select * from measure where slip_no='" + slipno_box.Text + "' ", db_connect);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Console.WriteLine("#" + dt.Rows[0][0]); // slip no
                    Console.WriteLine("##" + dt.Rows[0][1]); //
                    weight_box.Text = dt.Rows[0][1].ToString();
                    tire_weight_box.Text = dt.Rows[0][2].ToString();
                    net_weight_box.Text = dt.Rows[0][3].ToString();
                    Vehical_box.Text = dt.Rows[0][4].ToString();
                    Party_box.Text = dt.Rows[0][5].ToString();
                    meterial_box.Text = dt.Rows[0][6].ToString();
                    vechaltype_drop.Text = dt.Rows[0][7].ToString();
                    charges_drop.Text = dt.Rows[0][8].ToString();
                    date_box.Text = dt.Rows[0][9].ToString();
                    remarks_box.Text = dt.Rows[0][10].ToString();
                    tokenNo_box.Text = dt.Rows[0][14].ToString();
                    mod_date.Text = dt.Rows[0][12].ToString();
                    db_connect.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("exceptipon" + ex);
            }
        }
        private int calculate_netweight()
        {
            int weight = int.Parse(weight_box.Text);
            int tire_weight = int.Parse(tire_weight_box.Text);
            int net_weight = weight - tire_weight;
            return net_weight;

        }

        private void tire_weight_box_TextChanged(object sender, EventArgs e)
        {

        }
        public string get_slipseq()
        {

            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            String mk = LISTNER.active_mech.ToString().Replace(" ", ""); ;
            Console.WriteLine("value of mk33" + mk);
            SqlDataAdapter sda = new SqlDataAdapter("Select max(slip_no) from measure where slip_no like '" + mk + "%' ", db_connect);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            Console.WriteLine("value of dt &&##&@&#@&" + dt.Rows[0][0]);
            if (dt.Rows[0][0].ToString() == "")
            {
                String active_m = LISTNER.active_mech.Replace(" ", "");
                var slipseqdate = DateTime.Now.ToString("yyMMdd");

                String gen_slipno = "0000";
                gen_slipno = active_m + slipseqdate + gen_slipno;
                Console.WriteLine("value of sq!!!!" + gen_slipno);
                return gen_slipno;

            }
            else
            {
                db_connect.Close();
                return dt.Rows[0][0].ToString();

            }
        }

        private void addDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Machine_master machine_Master = new Machine_master();
            machine_Master.Show();
        }

        private void tareMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Charges_Master tare_Master = new Charges_Master();
            //tare_Master.Show();
            vehical_master vehical_Master = new vehical_master();
            vehical_Master.Show();
        }

        private void userMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Master user_Master = new User_Master();
            user_Master.Show();
        }

        private void chargesMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Charges_Master charges_Master = new Charges_Master();
            charges_Master.Show();
        }

        public void get_tyer()
        {
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select tyre from charge_master", db_connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                vechaltype_drop.Items.Add(dr["tyre"].ToString());
            }
            db_connect.Close();



        }

        public void get_charges()
        {
            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select charges from charge_master", db_connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                charges_drop.Items.Add(dr["charges"].ToString());
            }
            db_connect.Close();



        }

        private void vechaltype_drop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void pendingSlipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Pending_slips pending_Slips = new Reports.Pending_slips();
            pending_Slips.Show();
        }

        private void Vehical_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vehical_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            //var regex = new Regex(@"[^a-zA-Z0-9\s]");
            //if (regex.IsMatch(e.KeyChar.ToString()))
            //{
            //    e.Handled = true;
            //}

            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                       Char.IsSeparator(e.KeyChar) ||
                       Char.IsSymbol(e.KeyChar);

        }
        public void User_priv()
        {
            String get_priv = Form1.Session_priv;
            // master_Strip = new  as master_strip();
            Console.WriteLine("value og get session priv" + get_priv);
            if (get_priv.CompareTo("user") == 1)
            {

                master_strip.Enabled = false;
            }

        }

        private void slipRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Slip_Register slip_Register = new Reports.Slip_Register();
            slip_Register.Show();
        }

        private void charges_drop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cuttent_weight_box_TextChanged(object sender, EventArgs e)
        {



        }

        void crr_weight()
        {
            try
            {
                if (InvokeRequired)
                {
                    for (int i = 1; i > 0; i++)
                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            cuttent_weight_box.Text = b;
                            cuttent_weight_box.Text = LISTNER.ld_data.ToString();
                            //weight_box.Text = LISTNER.ld_data;
                           // cuttent_weight_box.Text = "hello";
                        });
                        Thread.Sleep(500);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex" + ex);
            }
           

            

        }

        private void Vehical_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
                SqlDataAdapter sda = new SqlDataAdapter("Select * from measure where vehical_no='" + Vehical_box.Text + "' and (net_weight = '' or net_weight = 'NULL' ) ", db_connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
               
                try
                {
                    if (dt.Rows.Count > 0)
                    {
                 
                        slipno_box.Text = dt.Rows[0][0].ToString().Trim();
                        weight_box.Text = dt.Rows[0][1].ToString().Trim();
                        tire_weight_box.Text  = dt.Rows[0][2].ToString().Trim();
                        net_weight_box.Text =  dt.Rows[0][3].ToString().Trim();
                        Party_box.Text = dt.Rows[0][5].ToString().Trim();
             
                        meterial_box.Text = dt.Rows[0][6].ToString().Trim();
                        vechaltype_drop.Text = dt.Rows[0][7].ToString().Trim();
                        charges_drop.Text = dt.Rows[0][8].ToString().Trim();
                        date_box.Text = dt.Rows[0][9].ToString().Trim();
                        remarks_box.Text = dt.Rows[0][10].ToString().Trim();
                        mod_date.Text = dt.Rows[0][13].ToString().Trim();
                        Console.WriteLine("value of challan@@#@"+ dt.Rows[0][13].ToString().Trim());
                        tokenNo_box.Text = dt.Rows[0][14].ToString().Trim();
                        
                    }

                    else
                    {
                        MessageBox.Show("Record not Found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("value enterd was not currect " + ex);

                }
                finally
                {
                    db_connect.Close();
                }
            }
        }

        private void ref_slipNo_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
                SqlDataAdapter sda = new SqlDataAdapter("Select vehical_no,date from measure where slip_no='" + ref_slipNo_box.Text + "' ", db_connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //Console.WriteLine("value of dt))))" + dt.Rows[0][0]); ;
                try
                {
                  charges_drop.Text = "0";
                    Vehical_box.Text = dt.Rows[0][0].ToString();
                    ref_dateSlip_no.Text = dt.Rows[0][1].ToString();







                }
                catch (Exception ex)
                {
                    MessageBox.Show("value enterd was not currect " + ex);

                }
                finally
                {
                    db_connect.Close();
                }
            }
        }
        public void get_printvalue()
        {


        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            //    pageSetupDialog1.PageSettings =
            //     new System.Drawing.Printing.PageSettings();
            //    pageSetupDialog1.PrinterSettings =
            //new System.Drawing.Printing.PrinterSettings();
            //    pageSetupDialog1.ShowNetwork = false;

            //    //Show the dialog storing the result.
            //    DialogResult result = pageSetupDialog1.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        object[] results = new object[]{
            //    pageSetupDialog1.PageSettings.Margins,
            //    pageSetupDialog1.PageSettings.PaperSize,
            //    pageSetupDialog1.PageSettings.Landscape,
            //    pageSetupDialog1.PrinterSettings.PrinterName,
            //    pageSetupDialog1.PrinterSettings.PrintRange};
            //        //ListBox1.Items.AddRange(results);
            //    }
            prn_slipno = slipno_box.Text;
            prn_partyname = Party_box.Text;
            prn_vehicle_type = vechaltype_drop.Text;
            prn_charges = charges_drop.Text;
            prn_op_name = Form1.User_sessson;
            prn_t_weight = tire_weight_box.Text;
            prn_g_weight = weight_box.Text;
            prn_n_weight = net_weight_box.Text;
            prn_product = meterial_box.Text;
            t_no = tokenNo_box.Text;
            cr_date = date_box.Text;
            mdate = mod_date.Text;
            veh_no = Vehical_box.Text;
            //Print.slip_print_frm slip_Print_Frm = new Print.slip_print_frm();
            //slip_Print_Frm.Show();
            slpprintPreviewDialog1.Document = slpprintDocument1;
            slpprintPreviewDialog1.Height = 1;
            slpprintPreviewDialog1.Width = 1;

            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select slip_no, print_count from measure  where slip_no='" + slipno_box.Text + "' ", db_connect);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            // Console.WriteLine("value of plant name" + dt1.Rows[0][0]);
            if (prn_n_weight.Length > 0 && prn_n_weight != "0")
            {
                if (dt1.Rows[0][1].ToString().Length == 0)
                {
                    String qry = "update   measure set print_count='1'  where slip_no = '" + slipno_box.Text + "'";
                    SqlCommand cmd = new SqlCommand(qry, db_connect);
                    cmd.ExecuteNonQuery();
                    db_connect.Close();
                    watermark = "Original";
                }
                else
                {
                    Int32 count = (int)dt1.Rows[0][1];
                    Int32 printCount = count + 1;
                    String qry = "update   measure set print_count='" + printCount + "'  where slip_no = '" + slipno_box.Text + "'";
                    SqlCommand cmd = new SqlCommand(qry, db_connect);
                    cmd.ExecuteNonQuery();
                    db_connect.Close();
                    watermark = "Duplicate";
                }
            }

            slpprintPreviewDialog1.ShowDialog();



        }

        private void slpprintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // e.Graphics.DrawString(label1.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 25));
            //e.Graphics.DrawString(addressalble.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(225, 50));
            string m_status = "Active";

            SqlConnection db_connect = new SqlConnection(db_Connection.connection_string());
            db_connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select plant_name,address from machine_master where m_status='" + m_status + "' ", db_connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);




            Console.WriteLine("value of plant name" + dt.Rows[0][0]);
            Console.WriteLine("value of plant name" + dt.Rows[0][1]);
            // string watermark = "Orignal Print";
            // Image Image = Image.FromFile("D:/logo-main.png");
            // System.Drawing.Graphics gpr = Graphics.FromImage(Image);
            System.Drawing.Brush brush = new SolidBrush(System.Drawing.Color.Red);
            Font font = new System.Drawing.Font("Arial", 55, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);

            SizeF size = e.Graphics.MeasureString(watermark, font);

            float y = 10;
            float x = 50;

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            SizeF txt = e.Graphics.MeasureString(Text, this.Font);
            SizeF sz = e.Graphics.VisibleClipBounds.Size;
            RectangleF printArea = new RectangleF(x, y, size.Width, size.Height);
            e.Graphics.RotateTransform(45);
            e.Graphics.DrawString(watermark, font, Brushes.LightGray, new RectangleF(0, 0, sz.Height, sz.Width), format);

            // e.Graphics.DrawString(watermark, font, Brushes.LightGray, printArea);
            e.Graphics.ResetTransform();
            //e.PageSettings.PaperSize.Width = 214;
            //e.PageSettings.PaperSize.Height= 105;
            //  e.PageSettings.PrinterSettings.DefaultPageSettings.PaperSize = ;
            e.Graphics.DrawString("Vehical No:  " + veh_no, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 250));
            e.Graphics.DrawString("Create Date:  " + cr_date, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 300));
            e.Graphics.DrawString("Final Date:  " + mdate, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 350));
            e.Graphics.DrawString(dt.Rows[0][0].ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(200, 25));
            e.Graphics.DrawString(dt.Rows[0][1].ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(125, 50));
            e.Graphics.DrawString("Slip No:  " + main.prn_slipno, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString("Party Name:  " + main.prn_partyname, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 100));
            e.Graphics.DrawString("Challan No:  " + main.t_no, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 150));
            e.Graphics.DrawString("Product:  " + main.prn_product, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 150));
            e.Graphics.DrawString("Vehicle Type:  " + main.prn_vehicle_type, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Charges:  " + main.prn_charges, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 200));
            e.Graphics.DrawString("Operator Name:  " + main.prn_op_name, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 400));
            e.Graphics.DrawString("Operator Sign:  ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 400));
            e.Graphics.DrawString("Tare Weight:  " + main.prn_t_weight, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Gross Weight:  " + main.prn_g_weight, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString("Net Weight:  " + main.prn_n_weight, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 350));




            slipno_box.Clear();
            weight_box.Clear();
            tire_weight_box.Clear();
            Vehical_box.Clear();
            charges_drop.Text = "";
            date_box.Clear();
            mod_date.Clear();
            vechaltype_drop.Text = "";
            remarks_box.Clear();
            meterial_box.Clear();
            Party_box.Clear();
            net_weight_box.Clear();
            tokenNo_box.Clear();



        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Change_Data change_Data = new Reports.Change_Data();
            change_Data.Show();

        }

        private void slpprintPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
}

