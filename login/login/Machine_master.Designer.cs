
namespace login
{
    partial class Machine_master
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.machineId_box = new System.Windows.Forms.TextBox();
            this.Portname_drop = new System.Windows.Forms.ComboBox();
            this.baudRate_box = new System.Windows.Forms.ComboBox();
            this.dataBit_box = new System.Windows.Forms.ComboBox();
            this.paraty_box = new System.Windows.Forms.ComboBox();
            this.stopBit_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prot Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baud Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // machineId_box
            // 
            this.machineId_box.Location = new System.Drawing.Point(316, 60);
            this.machineId_box.Name = "machineId_box";
            this.machineId_box.Size = new System.Drawing.Size(122, 26);
            this.machineId_box.TabIndex = 5;
            // 
            // Portname_drop
            // 
            this.Portname_drop.FormattingEnabled = true;
            this.Portname_drop.Location = new System.Drawing.Point(316, 99);
            this.Portname_drop.Name = "Portname_drop";
            this.Portname_drop.Size = new System.Drawing.Size(121, 28);
            this.Portname_drop.TabIndex = 6;
            // 
            // baudRate_box
            // 
            this.baudRate_box.FormattingEnabled = true;
            this.baudRate_box.Location = new System.Drawing.Point(316, 136);
            this.baudRate_box.Name = "baudRate_box";
            this.baudRate_box.Size = new System.Drawing.Size(121, 28);
            this.baudRate_box.TabIndex = 7;
            // 
            // dataBit_box
            // 
            this.dataBit_box.FormattingEnabled = true;
            this.dataBit_box.Location = new System.Drawing.Point(316, 181);
            this.dataBit_box.Name = "dataBit_box";
            this.dataBit_box.Size = new System.Drawing.Size(121, 28);
            this.dataBit_box.TabIndex = 8;
            this.dataBit_box.SelectedIndexChanged += new System.EventHandler(this.dataBit_box_SelectedIndexChanged);
            // 
            // paraty_box
            // 
            this.paraty_box.FormattingEnabled = true;
            this.paraty_box.Location = new System.Drawing.Point(316, 230);
            this.paraty_box.Name = "paraty_box";
            this.paraty_box.Size = new System.Drawing.Size(121, 28);
            this.paraty_box.TabIndex = 9;
            // 
            // stopBit_box
            // 
            this.stopBit_box.FormattingEnabled = true;
            this.stopBit_box.Location = new System.Drawing.Point(316, 276);
            this.stopBit_box.Name = "stopBit_box";
            this.stopBit_box.Size = new System.Drawing.Size(121, 28);
            this.stopBit_box.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stop Bit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(301, 351);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(137, 35);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Machine_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.stopBit_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.paraty_box);
            this.Controls.Add(this.dataBit_box);
            this.Controls.Add(this.baudRate_box);
            this.Controls.Add(this.Portname_drop);
            this.Controls.Add(this.machineId_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Machine_master";
            this.Text = "Machine_master";
            this.Load += new System.EventHandler(this.Machine_master_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox machineId_box;
        private System.Windows.Forms.ComboBox Portname_drop;
        private System.Windows.Forms.ComboBox baudRate_box;
        private System.Windows.Forms.ComboBox dataBit_box;
        private System.Windows.Forms.ComboBox paraty_box;
        private System.Windows.Forms.ComboBox stopBit_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Save;
    }
}