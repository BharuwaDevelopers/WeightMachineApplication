using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login.Reports
{
    public partial class Pending_slips : Form
    {
        public Pending_slips()
        {
            InitializeComponent();
        }

        private void pendingSlip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pending_slips_Load(object sender, EventArgs e)
        {
            try
            {
                this.measureTableAdapter1.FillBy1(this.weight_bridgeDataSet.measure);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


            //// TODO: This line of code loads data into the 'weight_bridgeDataSet.measure' table. You can move, or remove it, as needed.
            //this.measureTableAdapter1.Fill(this.weight_bridgeDataSet.measure);
            //// TODO: This line of code loads data into the 'db_measureDataSet.measure' table. You can move, or remove it, as needed.
            //this.measureTableAdapter.Fill(this.db_measureDataSet.measure);


        }

        private void excleToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
                Microsoft.Office.Interop.Excel._Application excel_Save = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = excel_Save.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet _Worksheet = null;
                _Worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets["Sheet1"];
                //workbook = workbook;
                _Worksheet.Name = "Pending_Slip";

                for (int i = 1; i < dataGridView1.Columns.Count+1; i++)
                {
                    _Worksheet.Cells[1,i] = dataGridView1.Columns[i - 1].HeaderText;

                }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)

                {

                    _Worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();


                }
            }
                    var saveFileDialoge = new SaveFileDialog();
                    saveFileDialoge.FileName = "Pending_slip";
                    saveFileDialoge.DefaultExt = ".xlsx";
                    if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    }

                    excel_Save.Quit();
                


            
     }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.measureTableAdapter1.FillBy1(this.weight_bridgeDataSet.measure);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
