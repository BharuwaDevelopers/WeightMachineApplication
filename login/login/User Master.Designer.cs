
namespace login
{
    partial class User_Master
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
            this.userid_box = new System.Windows.Forms.TextBox();
            this.userName_box = new System.Windows.Forms.TextBox();
            this.User_name = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.User_priv_drop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(226, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userid_box
            // 
            this.userid_box.Location = new System.Drawing.Point(296, 81);
            this.userid_box.Name = "userid_box";
            this.userid_box.ReadOnly = true;
            this.userid_box.Size = new System.Drawing.Size(217, 26);
            this.userid_box.TabIndex = 1;
            // 
            // userName_box
            // 
            this.userName_box.Location = new System.Drawing.Point(296, 130);
            this.userName_box.Name = "userName_box";
            this.userName_box.Size = new System.Drawing.Size(217, 26);
            this.userName_box.TabIndex = 3;
            // 
            // User_name
            // 
            this.User_name.AutoSize = true;
            this.User_name.BackColor = System.Drawing.Color.Transparent;
            this.User_name.Location = new System.Drawing.Point(201, 133);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(89, 20);
            this.User_name.TabIndex = 2;
            this.User_name.Text = "User Name";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(296, 183);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(217, 26);
            this.password_box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(212, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // User_priv_drop
            // 
            this.User_priv_drop.FormattingEnabled = true;
            this.User_priv_drop.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.User_priv_drop.Location = new System.Drawing.Point(296, 230);
            this.User_priv_drop.Name = "User_priv_drop";
            this.User_priv_drop.Size = new System.Drawing.Size(217, 28);
            this.User_priv_drop.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(185, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Privilege Type";
            // 
            // User_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.LOG_SCREEN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User_priv_drop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userName_box);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.userid_box);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "User_Master";
            this.Text = "UserMaster";
            this.Load += new System.EventHandler(this.User_Master_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userid_box;
        private System.Windows.Forms.TextBox userName_box;
        private System.Windows.Forms.Label User_name;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox User_priv_drop;
        private System.Windows.Forms.Label label2;
    }
}