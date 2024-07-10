
namespace login
{
    partial class vehical_master
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
            this.vehicalno_box = new System.Windows.Forms.TextBox();
            this.Save_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(188, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehical No";
            // 
            // vehicalno_box
            // 
            this.vehicalno_box.Location = new System.Drawing.Point(279, 112);
            this.vehicalno_box.Name = "vehicalno_box";
            this.vehicalno_box.Size = new System.Drawing.Size(265, 26);
            this.vehicalno_box.TabIndex = 1;
            this.vehicalno_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vehicalno_box_KeyPress);
            // 
            // Save_bttn
            // 
            this.Save_bttn.Location = new System.Drawing.Point(322, 180);
            this.Save_bttn.Name = "Save_bttn";
            this.Save_bttn.Size = new System.Drawing.Size(157, 38);
            this.Save_bttn.TabIndex = 2;
            this.Save_bttn.Text = "Save";
            this.Save_bttn.UseVisualStyleBackColor = true;
            this.Save_bttn.Click += new System.EventHandler(this.Save_bttn_Click);
            // 
            // vehical_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.LOG_SCREEN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save_bttn);
            this.Controls.Add(this.vehicalno_box);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "vehical_master";
            this.Text = "Vehicle Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicalno_box;
        private System.Windows.Forms.Button Save_bttn;
    }
}