
namespace login
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.weight_box = new System.Windows.Forms.TextBox();
            this.tire_weight_box = new System.Windows.Forms.TextBox();
            this.net_weight_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Vehical_box = new System.Windows.Forms.TextBox();
            this.Party_box = new System.Windows.Forms.TextBox();
            this.meterial_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.remarks_box = new System.Windows.Forms.RichTextBox();
            this.vechaltype_drop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.slipno_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.date_box = new System.Windows.Forms.TextBox();
            this.save_main = new System.Windows.Forms.Button();
            this.charges_drop = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.master_strip = new System.Windows.Forms.ToolStripSplitButton();
            this.userMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mechineMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargesMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.pendingSlipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slipRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cuttent_weight_box = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mod_date = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tokenNo_box = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ref_slipNo_box = new System.Windows.Forms.TextBox();
            this.ref_dateSlip_no = new System.Windows.Forms.Label();
            this.print_btn = new System.Windows.Forms.Button();
            this.slpprintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.slpprintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gross Weight";
            // 
            // weight_box
            // 
            this.weight_box.BackColor = System.Drawing.SystemColors.Window;
            this.weight_box.Location = new System.Drawing.Point(122, 3);
            this.weight_box.MaxLength = 10000;
            this.weight_box.Name = "weight_box";
            this.weight_box.ReadOnly = true;
            this.weight_box.Size = new System.Drawing.Size(129, 20);
            this.weight_box.TabIndex = 1;
            this.weight_box.TextChanged += new System.EventHandler(this.weight_box_TextChanged);
            this.weight_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.weight_box_KeyUp);
            // 
            // tire_weight_box
            // 
            this.tire_weight_box.BackColor = System.Drawing.SystemColors.Window;
            this.tire_weight_box.Location = new System.Drawing.Point(122, 52);
            this.tire_weight_box.Name = "tire_weight_box";
            this.tire_weight_box.ReadOnly = true;
            this.tire_weight_box.Size = new System.Drawing.Size(129, 20);
            this.tire_weight_box.TabIndex = 2;
            this.tire_weight_box.TextChanged += new System.EventHandler(this.tire_weight_box_TextChanged);
            // 
            // net_weight_box
            // 
            this.net_weight_box.BackColor = System.Drawing.SystemColors.Window;
            this.net_weight_box.Location = new System.Drawing.Point(122, 107);
            this.net_weight_box.Name = "net_weight_box";
            this.net_weight_box.ReadOnly = true;
            this.net_weight_box.Size = new System.Drawing.Size(129, 20);
            this.net_weight_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tare Weight";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Net Weight";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(3, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vehical No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Party";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(3, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Meterial";
            // 
            // Vehical_box
            // 
            this.Vehical_box.BackColor = System.Drawing.SystemColors.Window;
            this.Vehical_box.Location = new System.Drawing.Point(122, 165);
            this.Vehical_box.Name = "Vehical_box";
            this.Vehical_box.Size = new System.Drawing.Size(270, 20);
            this.Vehical_box.TabIndex = 9;
            this.Vehical_box.TextChanged += new System.EventHandler(this.Vehical_box_TextChanged);
            this.Vehical_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Vehical_box_KeyDown);
            this.Vehical_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vehical_box_KeyPress);
            // 
            // Party_box
            // 
            this.Party_box.BackColor = System.Drawing.SystemColors.Window;
            this.Party_box.Location = new System.Drawing.Point(122, 219);
            this.Party_box.Name = "Party_box";
            this.Party_box.Size = new System.Drawing.Size(270, 20);
            this.Party_box.TabIndex = 10;
            // 
            // meterial_box
            // 
            this.meterial_box.BackColor = System.Drawing.SystemColors.Window;
            this.meterial_box.Location = new System.Drawing.Point(122, 266);
            this.meterial_box.Name = "meterial_box";
            this.meterial_box.Size = new System.Drawing.Size(270, 20);
            this.meterial_box.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Remarks";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(3, 193);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Vehical Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // remarks_box
            // 
            this.remarks_box.BackColor = System.Drawing.SystemColors.Window;
            this.remarks_box.Location = new System.Drawing.Point(122, 323);
            this.remarks_box.Name = "remarks_box";
            this.remarks_box.Size = new System.Drawing.Size(270, 96);
            this.remarks_box.TabIndex = 15;
            this.remarks_box.Text = "";
            // 
            // vechaltype_drop
            // 
            this.vechaltype_drop.BackColor = System.Drawing.SystemColors.Window;
            this.vechaltype_drop.FormattingEnabled = true;
            this.vechaltype_drop.Location = new System.Drawing.Point(98, 196);
            this.vechaltype_drop.Name = "vechaltype_drop";
            this.vechaltype_drop.Size = new System.Drawing.Size(180, 21);
            this.vechaltype_drop.TabIndex = 16;
            this.vechaltype_drop.SelectedIndexChanged += new System.EventHandler(this.vechaltype_drop_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(3, 259);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Charges";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slipno_box
            // 
            this.slipno_box.BackColor = System.Drawing.SystemColors.Window;
            this.slipno_box.Location = new System.Drawing.Point(98, 3);
            this.slipno_box.Name = "slipno_box";
            this.slipno_box.Size = new System.Drawing.Size(180, 20);
            this.slipno_box.TabIndex = 19;
            this.slipno_box.TextChanged += new System.EventHandler(this.slipno_box_TextChanged);
            this.slipno_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.slipno_box_KeyDown);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Slip No";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(3, 93);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Date";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // date_box
            // 
            this.date_box.BackColor = System.Drawing.SystemColors.Window;
            this.date_box.Location = new System.Drawing.Point(98, 96);
            this.date_box.Name = "date_box";
            this.date_box.ReadOnly = true;
            this.date_box.Size = new System.Drawing.Size(180, 20);
            this.date_box.TabIndex = 21;
            // 
            // save_main
            // 
            this.save_main.BackColor = System.Drawing.SystemColors.Window;
            this.save_main.Location = new System.Drawing.Point(545, 600);
            this.save_main.Name = "save_main";
            this.save_main.Size = new System.Drawing.Size(96, 33);
            this.save_main.TabIndex = 24;
            this.save_main.Text = "Save";
            this.save_main.UseVisualStyleBackColor = false;
            this.save_main.Click += new System.EventHandler(this.save_main_Click);
            // 
            // charges_drop
            // 
            this.charges_drop.BackColor = System.Drawing.SystemColors.Window;
            this.charges_drop.FormattingEnabled = true;
            this.charges_drop.Location = new System.Drawing.Point(98, 262);
            this.charges_drop.Name = "charges_drop";
            this.charges_drop.Size = new System.Drawing.Size(180, 21);
            this.charges_drop.TabIndex = 25;
            this.charges_drop.SelectedIndexChanged += new System.EventHandler(this.charges_drop_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(107, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 26;
            this.button1.Text = "Get Weight";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(768, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 28;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.master_strip,
            this.toolStripSplitButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(998, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 22);
            this.toolStripSplitButton1.Text = "file";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // master_strip
            // 
            this.master_strip.BackColor = System.Drawing.SystemColors.Window;
            this.master_strip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.master_strip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMasterToolStripMenuItem,
            this.mechineMasterToolStripMenuItem,
            this.tareMasterToolStripMenuItem,
            this.chargesMasterToolStripMenuItem,
            this.dataChangeToolStripMenuItem});
            this.master_strip.Image = ((System.Drawing.Image)(resources.GetObject("master_strip.Image")));
            this.master_strip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.master_strip.Name = "master_strip";
            this.master_strip.Size = new System.Drawing.Size(59, 22);
            this.master_strip.Text = "Master";
            this.master_strip.ToolTipText = "Master";
            // 
            // userMasterToolStripMenuItem
            // 
            this.userMasterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.userMasterToolStripMenuItem.Name = "userMasterToolStripMenuItem";
            this.userMasterToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.userMasterToolStripMenuItem.Text = "User Master";
            this.userMasterToolStripMenuItem.Click += new System.EventHandler(this.userMasterToolStripMenuItem_Click);
            // 
            // mechineMasterToolStripMenuItem
            // 
            this.mechineMasterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.mechineMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeviceToolStripMenuItem,
            this.changeStatusToolStripMenuItem});
            this.mechineMasterToolStripMenuItem.Name = "mechineMasterToolStripMenuItem";
            this.mechineMasterToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mechineMasterToolStripMenuItem.Text = "Mechine Master";
            // 
            // addDeviceToolStripMenuItem
            // 
            this.addDeviceToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.addDeviceToolStripMenuItem.Name = "addDeviceToolStripMenuItem";
            this.addDeviceToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addDeviceToolStripMenuItem.Text = "Add Device";
            this.addDeviceToolStripMenuItem.Click += new System.EventHandler(this.addDeviceToolStripMenuItem_Click);
            // 
            // changeStatusToolStripMenuItem
            // 
            this.changeStatusToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.changeStatusToolStripMenuItem.Name = "changeStatusToolStripMenuItem";
            this.changeStatusToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.changeStatusToolStripMenuItem.Text = "Change Status";
            // 
            // tareMasterToolStripMenuItem
            // 
            this.tareMasterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.tareMasterToolStripMenuItem.Name = "tareMasterToolStripMenuItem";
            this.tareMasterToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tareMasterToolStripMenuItem.Text = "Vehical Master";
            this.tareMasterToolStripMenuItem.Click += new System.EventHandler(this.tareMasterToolStripMenuItem_Click);
            // 
            // chargesMasterToolStripMenuItem
            // 
            this.chargesMasterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.chargesMasterToolStripMenuItem.Name = "chargesMasterToolStripMenuItem";
            this.chargesMasterToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.chargesMasterToolStripMenuItem.Text = "Charges Master";
            this.chargesMasterToolStripMenuItem.Click += new System.EventHandler(this.chargesMasterToolStripMenuItem_Click);
            // 
            // dataChangeToolStripMenuItem
            // 
            this.dataChangeToolStripMenuItem.Name = "dataChangeToolStripMenuItem";
            this.dataChangeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dataChangeToolStripMenuItem.Text = "Data Change";
            this.dataChangeToolStripMenuItem.Click += new System.EventHandler(this.dataChangeToolStripMenuItem_Click);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendingSlipsToolStripMenuItem,
            this.slipRegisterToolStripMenuItem});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(63, 22);
            this.toolStripSplitButton3.Text = "Reports";
            // 
            // pendingSlipsToolStripMenuItem
            // 
            this.pendingSlipsToolStripMenuItem.Name = "pendingSlipsToolStripMenuItem";
            this.pendingSlipsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pendingSlipsToolStripMenuItem.Text = "Pending Slips";
            this.pendingSlipsToolStripMenuItem.Click += new System.EventHandler(this.pendingSlipsToolStripMenuItem_Click);
            // 
            // slipRegisterToolStripMenuItem
            // 
            this.slipRegisterToolStripMenuItem.Name = "slipRegisterToolStripMenuItem";
            this.slipRegisterToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.slipRegisterToolStripMenuItem.Text = "Slip Register";
            this.slipRegisterToolStripMenuItem.Click += new System.EventHandler(this.slipRegisterToolStripMenuItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(30, 190);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tare Weight";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(185, 190);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 17);
            this.radioButton2.TabIndex = 33;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Gross Weight";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cuttent_weight_box
            // 
            this.cuttent_weight_box.BackColor = System.Drawing.SystemColors.Window;
            this.cuttent_weight_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cuttent_weight_box.Location = new System.Drawing.Point(60, 76);
            this.cuttent_weight_box.Name = "cuttent_weight_box";
            this.cuttent_weight_box.Size = new System.Drawing.Size(216, 36);
            this.cuttent_weight_box.TabIndex = 35;
            this.cuttent_weight_box.Text = "";
            this.cuttent_weight_box.TextChanged += new System.EventHandler(this.cuttent_weight_box_TextChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(3, 133);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Modify Date";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mod_date
            // 
            this.mod_date.BackColor = System.Drawing.SystemColors.Window;
            this.mod_date.Location = new System.Drawing.Point(98, 136);
            this.mod_date.Name = "mod_date";
            this.mod_date.ReadOnly = true;
            this.mod_date.Size = new System.Drawing.Size(180, 20);
            this.mod_date.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(3, 56);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Challan No";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tokenNo_box
            // 
            this.tokenNo_box.BackColor = System.Drawing.SystemColors.Window;
            this.tokenNo_box.Location = new System.Drawing.Point(98, 59);
            this.tokenNo_box.Name = "tokenNo_box";
            this.tokenNo_box.Size = new System.Drawing.Size(180, 20);
            this.tokenNo_box.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(677, 674);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Reference Slip No";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Visible = false;
            // 
            // ref_slipNo_box
            // 
            this.ref_slipNo_box.BackColor = System.Drawing.SystemColors.Window;
            this.ref_slipNo_box.Enabled = false;
            this.ref_slipNo_box.Location = new System.Drawing.Point(777, 667);
            this.ref_slipNo_box.Name = "ref_slipNo_box";
            this.ref_slipNo_box.Size = new System.Drawing.Size(180, 20);
            this.ref_slipNo_box.TabIndex = 41;
            this.ref_slipNo_box.Visible = false;
            this.ref_slipNo_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ref_slipNo_box_KeyDown);
            // 
            // ref_dateSlip_no
            // 
            this.ref_dateSlip_no.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ref_dateSlip_no.AutoSize = true;
            this.ref_dateSlip_no.BackColor = System.Drawing.Color.Transparent;
            this.ref_dateSlip_no.Location = new System.Drawing.Point(827, 215);
            this.ref_dateSlip_no.Name = "ref_dateSlip_no";
            this.ref_dateSlip_no.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ref_dateSlip_no.Size = new System.Drawing.Size(0, 13);
            this.ref_dateSlip_no.TabIndex = 43;
            this.ref_dateSlip_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.SystemColors.Window;
            this.print_btn.Location = new System.Drawing.Point(656, 600);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(96, 33);
            this.print_btn.TabIndex = 44;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // slpprintDocument1
            // 
            this.slpprintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.slpprintDocument1_PrintPage);
            // 
            // slpprintPreviewDialog1
            // 
            this.slpprintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.slpprintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.slpprintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.slpprintPreviewDialog1.Enabled = true;
            this.slpprintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("slpprintPreviewDialog1.Icon")));
            this.slpprintPreviewDialog1.Name = "slpprintPreviewDialog1";
            this.slpprintPreviewDialog1.Visible = false;
            this.slpprintPreviewDialog1.Load += new System.EventHandler(this.slpprintPreviewDialog1_Load);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.24831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.75169F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tire_weight_box, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.net_weight_box, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Vehical_box, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Party_box, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.meterial_box, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.remarks_box, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.weight_box, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 273);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.10744F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.89256F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 438);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.96208F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.03792F));
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.date_box, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.mod_date, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.vechaltype_drop, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.charges_drop, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tokenNo_box, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.slipno_box, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(456, 231);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(501, 353);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 747);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.ref_dateSlip_no);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ref_slipNo_box);
            this.Controls.Add(this.cuttent_weight_box);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save_main);
            this.DoubleBuffered = true;
            this.Name = "main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "BSPL V1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weight_box;
        private System.Windows.Forms.TextBox tire_weight_box;
        private System.Windows.Forms.TextBox net_weight_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Vehical_box;
        private System.Windows.Forms.TextBox Party_box;
        private System.Windows.Forms.TextBox meterial_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox remarks_box;
        private System.Windows.Forms.ComboBox vechaltype_drop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox slipno_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox date_box;
        private System.Windows.Forms.Button save_main;
        private System.Windows.Forms.ComboBox charges_drop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton master_strip;
        private System.Windows.Forms.ToolStripMenuItem userMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mechineMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareMasterToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox cuttent_weight_box;
        private System.Windows.Forms.ToolStripMenuItem addDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargesMasterToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox mod_date;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem pendingSlipsToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tokenNo_box;
        private System.Windows.Forms.ToolStripMenuItem slipRegisterToolStripMenuItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ref_slipNo_box;
        private System.Windows.Forms.Label ref_dateSlip_no;
        private System.Windows.Forms.Button print_btn;
        private System.Drawing.Printing.PrintDocument slpprintDocument1;
        private System.Windows.Forms.PrintPreviewDialog slpprintPreviewDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem dataChangeToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}