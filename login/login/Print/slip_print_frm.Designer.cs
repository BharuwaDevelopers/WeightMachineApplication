
namespace login.Print
{
    partial class slip_print_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(slip_print_frm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.slip_no_prn = new System.Windows.Forms.TextBox();
            this.token_no_prn = new System.Windows.Forms.TextBox();
            this.party_name_prn = new System.Windows.Forms.TextBox();
            this.vehicle_type_prn = new System.Windows.Forms.TextBox();
            this.product_prn = new System.Windows.Forms.TextBox();
            this.charges_prn = new System.Windows.Forms.TextBox();
            this.tare_weight_prn = new System.Windows.Forms.TextBox();
            this.gross_weight_prn = new System.Windows.Forms.TextBox();
            this.net_weight_prn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.operator_name_prn = new System.Windows.Forms.TextBox();
            this.Slip_PreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.slip_printDocument = new System.Drawing.Printing.PrintDocument();
            this.print = new System.Windows.Forms.Button();
            this.addressalble = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATANJALI FOOD & HERBAL PARK PVT LTD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slip No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Party Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Token No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vehicle Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Charges";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tare Weight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gross Weight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Net Weight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(662, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Operator Sign: _____________";
            // 
            // slip_no_prn
            // 
            this.slip_no_prn.Location = new System.Drawing.Point(125, 144);
            this.slip_no_prn.Name = "slip_no_prn";
            this.slip_no_prn.Size = new System.Drawing.Size(100, 26);
            this.slip_no_prn.TabIndex = 11;
            // 
            // token_no_prn
            // 
            this.token_no_prn.Location = new System.Drawing.Point(125, 213);
            this.token_no_prn.Name = "token_no_prn";
            this.token_no_prn.Size = new System.Drawing.Size(100, 26);
            this.token_no_prn.TabIndex = 12;
            // 
            // party_name_prn
            // 
            this.party_name_prn.Location = new System.Drawing.Point(687, 138);
            this.party_name_prn.Name = "party_name_prn";
            this.party_name_prn.Size = new System.Drawing.Size(100, 26);
            this.party_name_prn.TabIndex = 13;
            // 
            // vehicle_type_prn
            // 
            this.vehicle_type_prn.Location = new System.Drawing.Point(124, 280);
            this.vehicle_type_prn.Name = "vehicle_type_prn";
            this.vehicle_type_prn.Size = new System.Drawing.Size(100, 26);
            this.vehicle_type_prn.TabIndex = 14;
            // 
            // product_prn
            // 
            this.product_prn.Location = new System.Drawing.Point(687, 207);
            this.product_prn.Name = "product_prn";
            this.product_prn.Size = new System.Drawing.Size(100, 26);
            this.product_prn.TabIndex = 15;
            // 
            // charges_prn
            // 
            this.charges_prn.Location = new System.Drawing.Point(687, 268);
            this.charges_prn.Name = "charges_prn";
            this.charges_prn.Size = new System.Drawing.Size(100, 26);
            this.charges_prn.TabIndex = 16;
            // 
            // tare_weight_prn
            // 
            this.tare_weight_prn.Location = new System.Drawing.Point(250, 368);
            this.tare_weight_prn.Name = "tare_weight_prn";
            this.tare_weight_prn.Size = new System.Drawing.Size(100, 26);
            this.tare_weight_prn.TabIndex = 17;
            // 
            // gross_weight_prn
            // 
            this.gross_weight_prn.Location = new System.Drawing.Point(250, 412);
            this.gross_weight_prn.Name = "gross_weight_prn";
            this.gross_weight_prn.Size = new System.Drawing.Size(100, 26);
            this.gross_weight_prn.TabIndex = 18;
            // 
            // net_weight_prn
            // 
            this.net_weight_prn.Location = new System.Drawing.Point(250, 452);
            this.net_weight_prn.Name = "net_weight_prn";
            this.net_weight_prn.Size = new System.Drawing.Size(100, 26);
            this.net_weight_prn.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(555, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Operator Name";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // operator_name_prn
            // 
            this.operator_name_prn.Location = new System.Drawing.Point(687, 329);
            this.operator_name_prn.Name = "operator_name_prn";
            this.operator_name_prn.Size = new System.Drawing.Size(100, 26);
            this.operator_name_prn.TabIndex = 21;
            // 
            // Slip_PreviewDialog
            // 
            this.Slip_PreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Slip_PreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Slip_PreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.Slip_PreviewDialog.Enabled = true;
            this.Slip_PreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("Slip_PreviewDialog.Icon")));
            this.Slip_PreviewDialog.Name = "Slip_PreviewDialog";
            this.Slip_PreviewDialog.Visible = false;
            this.Slip_PreviewDialog.Load += new System.EventHandler(this.Slip_PreviewDialog_Load);
            // 
            // slip_printDocument
            // 
            this.slip_printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.slip_printDocument_PrintPage);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(409, 477);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(130, 35);
            this.print.TabIndex = 22;
            this.print.Text = "print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // addressalble
            // 
            this.addressalble.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressalble.AutoSize = true;
            this.addressalble.Location = new System.Drawing.Point(301, 80);
            this.addressalble.Name = "addressalble";
            this.addressalble.Size = new System.Drawing.Size(333, 20);
            this.addressalble.TabIndex = 23;
            this.addressalble.Text = "PATANJALI FOOD & HERBAL PARK PVT LTD";
            this.addressalble.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // slip_print_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 537);
            this.Controls.Add(this.addressalble);
            this.Controls.Add(this.print);
            this.Controls.Add(this.operator_name_prn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.net_weight_prn);
            this.Controls.Add(this.gross_weight_prn);
            this.Controls.Add(this.tare_weight_prn);
            this.Controls.Add(this.charges_prn);
            this.Controls.Add(this.product_prn);
            this.Controls.Add(this.vehicle_type_prn);
            this.Controls.Add(this.party_name_prn);
            this.Controls.Add(this.token_no_prn);
            this.Controls.Add(this.slip_no_prn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "slip_print_frm";
            this.Text = "slip_print_frm";
            this.Load += new System.EventHandler(this.slip_print_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox slip_no_prn;
        private System.Windows.Forms.TextBox token_no_prn;
        private System.Windows.Forms.TextBox party_name_prn;
        private System.Windows.Forms.TextBox vehicle_type_prn;
        private System.Windows.Forms.TextBox product_prn;
        private System.Windows.Forms.TextBox charges_prn;
        private System.Windows.Forms.TextBox tare_weight_prn;
        private System.Windows.Forms.TextBox gross_weight_prn;
        private System.Windows.Forms.TextBox net_weight_prn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox operator_name_prn;
        private System.Windows.Forms.PrintPreviewDialog Slip_PreviewDialog;
        private System.Drawing.Printing.PrintDocument slip_printDocument;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label addressalble;
    }
}