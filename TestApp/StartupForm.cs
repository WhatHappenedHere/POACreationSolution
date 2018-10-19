using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.DataHandler;
using System.IO;

namespace TestApp
{
    public partial class mainForm : Form
    {
        POAFileHandler poaFileHandler = new POAFileHandler();
        
        public mainForm()
        {
            InitializeComponent();
            dgvTemp.AutoGenerateColumns = false;
            string[] loadedBaseData = poaFileHandler.loadBaseData();
            Dictionary<int, string[]> loadedPOAs = new Dictionary<int, string[]>();
            if (loadedBaseData != null)
            {
                loadedPOAs = poaFileHandler.dividePOAs(loadedBaseData);
                fillTable(loadedPOAs);
            }
        }

        public void fillTable(Dictionary<int, string[]> tableData)
        {
            string[] products;
            for (int i = 0; i < tableData.Count-1; i++)
            {
                products = poaFileHandler.divideBySymbol(tableData[i].GetValue(1).ToString());

                for (int j = 0; j < products.Length / 2; j++)
                    dgvTemp.Rows.Add(i+1, products[j * 2], products[j * 2 + 1],
                        tableData[i].GetValue(2).ToString(), tableData[i].GetValue(3).ToString(), 
                        tableData[i].GetValue(4).ToString());
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogPOA.Filter = "poa files (*.poa)|*.poa|All files (*.*)|*.*";
            openFileDialogPOA.Title = "Вибір файла";           

            if(openFileDialogPOA.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DocumentForm documentForm = new DocumentForm();
                    string[] tableData = poaFileHandler.readFromDialog(openFileDialogPOA);
                    POAElements poaElements = new POAElements(tableData[0]);

                    documentForm = poaFileHandler.poaReading(tableData,poaElements);
                    documentForm.Show();
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Неможливо відкрити файл!\n" +
                                    "Текст помилки: " + exception.Message,"Помилка", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

        }

        private void створитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentForm documentForm = new DocumentForm();
            documentForm.Show();

        }

        bool IsTheSameCellValue(int column, int row,DataGridView dataGridView)
        {
            DataGridViewCell cell1 = dataGridView[column, row];
            DataGridViewCell cell2 = dataGridView[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void dgvTemp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int poeNumber = (int)dgvTemp[0, e.RowIndex].Value;

        }

        private void dgvTemp_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex,dgvTemp))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dgvTemp.AdvancedCellBorderStyle.Top;
            }
        }

        private void dgvTemp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex,dgvTemp))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }
    }
}
