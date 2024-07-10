
namespace login.Reports
{
    partial class Change_Data
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
            this.weight_bridgeDataSet3 = new login.weight_bridgeDataSet3();
            this.measureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.measureTableAdapter = new login.weight_bridgeDataSet3TableAdapters.measureTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_bridgeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.DataSource = this.measureBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // weight_bridgeDataSet3
            // 
            this.weight_bridgeDataSet3.DataSetName = "weight_bridgeDataSet3";
            this.weight_bridgeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // measureBindingSource
            // 
            this.measureBindingSource.DataMember = "measure";
            this.measureBindingSource.DataSource = this.weight_bridgeDataSet3;
            // 
            // measureTableAdapter
            // 
            this.measureTableAdapter.ClearBeforeFill = true;
            // 
            // slipnoDataGridViewTextBoxColumn
            // 
            this.slipnoDataGridViewTextBoxColumn.DataPropertyName = "slip_no";
            this.slipnoDataGridViewTextBoxColumn.HeaderText = "slip_no";
            this.slipnoDataGridViewTextBoxColumn.Name = "slipnoDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // tireweightDataGridViewTextBoxColumn
            // 
            this.tireweightDataGridViewTextBoxColumn.DataPropertyName = "tire_weight";
            this.tireweightDataGridViewTextBoxColumn.HeaderText = "tire_weight";
            this.tireweightDataGridViewTextBoxColumn.Name = "tireweightDataGridViewTextBoxColumn";
            // 
            // netweightDataGridViewTextBoxColumn
            // 
            this.netweightDataGridViewTextBoxColumn.DataPropertyName = "net_weight";
            this.netweightDataGridViewTextBoxColumn.HeaderText = "net_weight";
            this.netweightDataGridViewTextBoxColumn.Name = "netweightDataGridViewTextBoxColumn";
            // 
            // vehicalnoDataGridViewTextBoxColumn
            // 
            this.vehicalnoDataGridViewTextBoxColumn.DataPropertyName = "vehical_no";
            this.vehicalnoDataGridViewTextBoxColumn.HeaderText = "vehical_no";
            this.vehicalnoDataGridViewTextBoxColumn.Name = "vehicalnoDataGridViewTextBoxColumn";
            // 
            // partyDataGridViewTextBoxColumn
            // 
            this.partyDataGridViewTextBoxColumn.DataPropertyName = "party";
            this.partyDataGridViewTextBoxColumn.HeaderText = "party";
            this.partyDataGridViewTextBoxColumn.Name = "partyDataGridViewTextBoxColumn";
            // 
            // meterialDataGridViewTextBoxColumn
            // 
            this.meterialDataGridViewTextBoxColumn.DataPropertyName = "meterial";
            this.meterialDataGridViewTextBoxColumn.HeaderText = "meterial";
            this.meterialDataGridViewTextBoxColumn.Name = "meterialDataGridViewTextBoxColumn";
            // 
            // vehicaltypeDataGridViewTextBoxColumn
            // 
            this.vehicaltypeDataGridViewTextBoxColumn.DataPropertyName = "vehical_type";
            this.vehicaltypeDataGridViewTextBoxColumn.HeaderText = "vehical_type";
            this.vehicaltypeDataGridViewTextBoxColumn.Name = "vehicaltypeDataGridViewTextBoxColumn";
            // 
            // chargesDataGridViewTextBoxColumn
            // 
            this.chargesDataGridViewTextBoxColumn.DataPropertyName = "charges";
            this.chargesDataGridViewTextBoxColumn.HeaderText = "charges";
            this.chargesDataGridViewTextBoxColumn.Name = "chargesDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // moddateDataGridViewTextBoxColumn
            // 
            this.moddateDataGridViewTextBoxColumn.DataPropertyName = "mod_date";
            this.moddateDataGridViewTextBoxColumn.HeaderText = "mod_date";
            this.moddateDataGridViewTextBoxColumn.Name = "moddateDataGridViewTextBoxColumn";
            // 
            // modbyDataGridViewTextBoxColumn
            // 
            this.modbyDataGridViewTextBoxColumn.DataPropertyName = "mod_by";
            this.modbyDataGridViewTextBoxColumn.HeaderText = "mod_by";
            this.modbyDataGridViewTextBoxColumn.Name = "modbyDataGridViewTextBoxColumn";
            // 
            // tokennoDataGridViewTextBoxColumn
            // 
            this.tokennoDataGridViewTextBoxColumn.DataPropertyName = "token_no";
            this.tokennoDataGridViewTextBoxColumn.HeaderText = "token_no";
            this.tokennoDataGridViewTextBoxColumn.Name = "tokennoDataGridViewTextBoxColumn";
            // 
            // Change_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Change_Data";
            this.Text = "Change_Data";
            this.Load += new System.EventHandler(this.Change_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_bridgeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private weight_bridgeDataSet3 weight_bridgeDataSet3;
        private System.Windows.Forms.BindingSource measureBindingSource;
        private weight_bridgeDataSet3TableAdapters.measureTableAdapter measureTableAdapter;
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
    }
}