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
    public partial class Slip_Register : Form
    {
        public Slip_Register()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Slip_Register_Load(object sender, EventArgs e)
        {
            try { 
            // TODO: This line of code loads data into the 'weight_bridgeDataSet1.measure' table. You can move, or remove it, as needed.
            this.measureTableAdapter.Fill(this.weight_bridgeDataSet1.measure);
            // TODO: This line of code loads data into the 'db_measureDataSet1.measure' table. You can move, or remove it, as needed.
        }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

}

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void excleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application excel_Save = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel_Save.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet _Worksheet = null;
            _Worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets["Sheet1"];
            //workbook = workbook;
            _Worksheet.Name = "Slip_Register";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                _Worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)

                {

                    _Worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();


                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Slip_Register";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }

            excel_Save.Quit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
