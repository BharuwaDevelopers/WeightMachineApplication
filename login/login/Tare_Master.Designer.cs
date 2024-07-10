
namespace login
{
    partial class Charges_Master
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
            this.tareM_box = new System.Windows.Forms.TextBox();
            this.chargesM_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tyre Type";
            // 
            // tareM_box
            // 
            this.tareM_box.Location = new System.Drawing.Point(251, 113);
            this.tareM_box.Name = "tareM_box";
            this.tareM_box.Size = new System.Drawing.Size(172, 26);
            this.tareM_box.TabIndex = 1;
            // 
            // chargesM_box
            // 
            this.chargesM_box.Location = new System.Drawing.Point(251, 160);
            this.chargesM_box.Name = "chargesM_box";
            this.chargesM_box.Size = new System.Drawing.Size(172, 26);
            this.chargesM_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Charges";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(266, 233);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(133, 51);
            this.save_but.TabIndex = 4;
            this.save_but.Text = "Save";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // Charges_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.chargesM_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tareM_box);
            this.Controls.Add(this.label1);
            this.Name = "Charges_Master";
            this.Text = "Charges Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tareM_box;
        private System.Windows.Forms.TextBox chargesM_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_but;
    }
}