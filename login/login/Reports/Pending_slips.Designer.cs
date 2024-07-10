
namespace login.Reports
{
    partial class Pending_slips
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.slipnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tireweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicalnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicaltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokennoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.weight_bridgeDataSet = new login.weight_bridgeDataSet();
            this.measureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_measureDataSet = new login.db_measureDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measureTableAdapter = new login.db_measureDataSetTableAdapters.measureTableAdapter();
            this.measureTableAdapter1 = new login.weight_bridgeDataSetTableAdapters.measureTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measureBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_bridgeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_measureDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slipnoDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.tireweightDataGridViewTextBoxColumn,
            this.netweightDataGridViewTextBoxColumn,
            this.vehicalnoDataGridViewTextBoxColumn,
            this.partyDataGridViewTextBoxColumn,
            this.meterialDataGridViewTextBoxColumn,
            this.vehicaltypeDataGridViewTextBoxColumn,
            this.chargesDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.moddateDataGridViewTextBoxColumn,
            this.modbyDataGridViewTextBoxColumn,
            this.tokennoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.measureBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(756, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // slipnoDataGridViewTextBoxColumn
            // 
            this.slipnoDataGridViewTextBoxColumn.DataPropertyName = "slip_no";
            this.slipnoDataGridViewTextBoxColumn.HeaderText = "slip_no";
            this.slipnoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.slipnoDataGridViewTextBoxColumn.Name = "slipnoDataGridViewTextBoxColumn";
            this.slipnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 150;
            // 
            // tireweightDataGridViewTextBoxColumn
            // 
            this.tireweightDataGridViewTextBoxColumn.DataPropertyName = "tire_weight";
            this.tireweightDataGridViewTextBoxColumn.HeaderText = "tire_weight";
            this.tireweightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tireweightDataGridViewTextBoxColumn.Name = "tireweightDataGridViewTextBoxColumn";
            this.tireweightDataGridViewTextBoxColumn.Width = 150;
            // 
            // netweightDataGridViewTextBoxColumn
            // 
            this.netweightDataGridViewTextBoxColumn.DataPropertyName = "net_weight";
            this.netweightDataGridViewTextBoxColumn.HeaderText = "net_weight";
            this.netweightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.netweightDataGridViewTextBoxColumn.Name = "netweightDataGridViewTextBoxColumn";
            this.netweightDataGridViewTextBoxColumn.Width = 150;
            // 
            // vehicalnoDataGridViewTextBoxColumn
            // 
            this.vehicalnoDataGridViewTextBoxColumn.DataPropertyName = "vehical_no";
            this.vehicalnoDataGridViewTextBoxColumn.HeaderText = "vehical_no";
            this.vehicalnoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vehicalnoDataGridViewTextBoxColumn.Name = "vehicalnoDataGridViewTextBoxColumn";
            this.vehicalnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // partyDataGridViewTextBoxColumn
            // 
            this.partyDataGridViewTextBoxColumn.DataPropertyName = "party";
            this.partyDataGridViewTextBoxColumn.HeaderText = "party";
            this.partyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partyDataGridViewTextBoxColumn.Name = "partyDataGridViewTextBoxColumn";
            this.partyDataGridViewTextBoxColumn.Width = 150;
            // 
            // meterialDataGridViewTextBoxColumn
            // 
            this.meterialDataGridViewTextBoxColumn.DataPropertyName = "meterial";
            this.meterialDataGridViewTextBoxColumn.HeaderText = "meterial";
            this.meterialDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.meterialDataGridViewTextBoxColumn.Name = "meterialDataGridViewTextBoxColumn";
            this.meterialDataGridViewTextBoxColumn.Width = 150;
            // 
            // vehicaltypeDataGridViewTextBoxColumn
            // 
            this.vehicaltypeDataGridViewTextBoxColumn.DataPropertyName = "vehical_type";
            this.vehicaltypeDataGridViewTextBoxColumn.HeaderText = "vehical_type";
            this.vehicaltypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vehicaltypeDataGridViewTextBoxColumn.Name = "vehicaltypeDataGridViewTextBoxColumn";
            this.vehicaltypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // chargesDataGridViewTextBoxColumn
            // 
            this.chargesDataGridViewTextBoxColumn.DataPropertyName = "charges";
            this.chargesDataGridViewTextBoxColumn.HeaderText = "charges";
            this.chargesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chargesDataGridViewTextBoxColumn.Name = "chargesDataGridViewTextBoxColumn";
            this.chargesDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "remarks";
            this.remarksDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.Width = 150;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // moddateDataGridViewTextBoxColumn
            // 
            this.moddateDataGridViewTextBoxColumn.DataPropertyName = "mod_date";
            this.moddateDataGridViewTextBoxColumn.HeaderText = "mod_date";
            this.moddateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.moddateDataGridViewTextBoxColumn.Name = "moddateDataGridViewTextBoxColumn";
            this.moddateDataGridViewTextBoxColumn.Width = 150;
            // 
            // modbyDataGridViewTextBoxColumn
            // 
            this.modbyDataGridViewTextBoxColumn.DataPropertyName = "mod_by";
            this.modbyDataGridViewTextBoxColumn.HeaderText = "mod_by";
            this.modbyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modbyDataGridViewTextBoxColumn.Name = "modbyDataGridViewTextBoxColumn";
            this.modbyDataGridViewTextBoxColumn.Width = 150;
            // 
            // tokennoDataGridViewTextBoxColumn
            // 
            this.tokennoDataGridViewTextBoxColumn.DataPropertyName = "token_no";
            this.tokennoDataGridViewTextBoxColumn.HeaderText = "token_no";
            this.tokennoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tokennoDataGridViewTextBoxColumn.Name = "tokennoDataGridViewTextBoxColumn";
            this.tokennoDataGridViewTextBoxColumn.Width = 150;
            // 
            // measureBindingSource1
            // 
            this.measureBindingSource1.DataMember = "measure";
            this.measureBindingSource1.DataSource = this.weight_bridgeDataSet;
            // 
            // weight_bridgeDataSet
            // 
            this.weight_bridgeDataSet.DataSetName = "weight_bridgeDataSet";
            this.weight_bridgeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // measureBindingSource
            // 
            this.measureBindingSource.DataMember = "measure";
            this.measureBindingSource.DataSource = this.db_measureDataSet;
            // 
            // db_measureDataSet
            // 
            this.db_measureDataSet.DataSetName = "db_measureDataSet";
            this.db_measureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excleToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // excleToolStripMenuItem
            // 
            this.excleToolStripMenuItem.Name = "excleToolStripMenuItem";
            this.excleToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.excleToolStripMenuItem.Text = "Excle";
            this.excleToolStripMenuItem.Click += new System.EventHandler(this.excleToolStripMenuItem_Click);
            // 
            // measureTableAdapter
            // 
            this.measureTableAdapter.ClearBeforeFill = true;
            // 
            // measureTableAdapter1
            // 
            this.measureTableAdapter1.ClearBeforeFill = true;
            // 
            // Pending_slips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 357);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pending_slips";
            this.Text = "Pending Slips";
            this.Load += new System.EventHandler(this.Pending_slips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measureBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_bridgeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_measureDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excleToolStripMenuItem;
        private db_measureDataSet db_measureDataSet;
        private System.Windows.Forms.BindingSource measureBindingSource;
        private db_measureDataSetTableAdapters.measureTableAdapter measureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn slipnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tireweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicalnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicaltypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokennoDataGridViewTextBoxColumn;
        private weight_bridgeDataSet weight_bridgeDataSet;
        private System.Windows.Forms.BindingSource measureBindingSource1;
        private weight_bridgeDataSetTableAdapters.measureTableAdapter measureTableAdapter1;
    }
}