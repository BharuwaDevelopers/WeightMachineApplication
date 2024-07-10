using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.Reports
{
    public partial class Change_Data : Form
    {
        public Change_Data()
        {
            InitializeComponent();
        }

        private void Change_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'weight_bridgeDataSet3.measure' table. You can move, or remove it, as needed.
            this.measureTableAdapter.Fill(this.weight_bridgeDataSet3.measure);

            // TODO: This line of code loads data into the 'weight_bridgeDataSet2.measure' table. You can move, or remove it, as needed.

            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
         

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
