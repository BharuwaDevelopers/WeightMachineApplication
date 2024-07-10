using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.Print
{
    public partial class slip_print_frm : Form
    {
        public slip_print_frm()
        {
            InitializeComponent();
        }

        private void slip_print_frm_Load(object sender, EventArgs e)
        {
         
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            Slip_PreviewDialog.Document = slip_printDocument;
            Slip_PreviewDialog.ShowDialog();
        }

        private void slip_printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bmp = Properties.Resources.LOG_SCREEN;
            //Image image = bmp;

            //e.Graphics.DrawImage( image, 25, 25,image.Width,image.Height);
            
            
            
            addressalble.Text = "VILL PADHARTA LAKSAR ROAD HARIDWAR (U.K)";
            e.Graphics.DrawString( label1.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250,25));
            e.Graphics.DrawString(addressalble.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(225, 50));
            e.Graphics.DrawString("Slip No:  "+main.prn_slipno , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString("Party Name:  " +main.prn_partyname, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 100));
            e.Graphics.DrawString("Token No:  " + main.t_no, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 150));
            e.Graphics.DrawString("Product:  " + main.prn_product, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 150));
            e.Graphics.DrawString("Vehicle Type:  " + main.prn_vehicle_type, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Charges:  " + main.prn_charges, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 200));
            e.Graphics.DrawString("Operator Name:  " + main.prn_op_name, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 250));
            e.Graphics.DrawString("Operator Sign:  " , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 400));
            e.Graphics.DrawString("Tare Weight:  " + main.prn_t_weight, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Gross Weight:  " +  main.prn_g_weight, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString("Net Weight:  " + main.prn_n_weight, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 350));

        }

        private void Slip_PreviewDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
