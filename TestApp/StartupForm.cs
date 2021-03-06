﻿using System;
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
        Dictionary<int, string[]> loadedPOAs = new Dictionary<int, string[]>();
        public mainForm()
        {
            InitializeComponent();
            dgvTemp.AutoGenerateColumns = false;
            fillMainTable();
        }

        public void fillMainTable()
        {
            string[] loadedBaseData = poaFileHandler.loadBaseData();
            
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
                DateTime dateTime = DateTime.Parse(tableData[i].GetValue(4).ToString());

                for (int j = 0; j < products.Length / 2; j++)
                {
                    if (DateTime.Now.CompareTo(dateTime) > 0)
                    {
                        dgvComplited.Rows.Add(i + 1, products[j * 2], products[j * 2 + 1],
                        tableData[i].GetValue(2).ToString(), tableData[i].GetValue(3).ToString(),
                        tableData[i].GetValue(4).ToString(), tableData[i].GetValue(0).ToString());
                    }
                    else
                        dgvTemp.Rows.Add(i + 1, products[j * 2], products[j * 2 + 1],
                        tableData[i].GetValue(2).ToString(), tableData[i].GetValue(3).ToString(),
                        tableData[i].GetValue(4).ToString(), tableData[i].GetValue(0).ToString());
                }
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
                    poaFileHandler.writeIntoBase(documentForm.concatenateString(),openFileDialogPOA.FileName);
                    
                    
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
            if (e.RowIndex < 0|| dgvTemp[columnDocumentNumber.Index, e.RowIndex].Value==null) return;
            try
            {
                DocumentForm documentForm = new DocumentForm();
                string[] tableData = poaFileHandler.readFileData(dgvTemp[6,e.RowIndex].Value.ToString());
                POAElements poaElements = new POAElements(tableData[0]);

                documentForm = poaFileHandler.poaReading(tableData, poaElements);
                documentForm.Show();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Неможливо відкрити файл!\n" +
                                "Текст помилки: " + exception.Message, "Помилка", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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

        private void оновитиТаблицюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvTemp.Rows.Clear();
            dgvComplited.Rows.Clear();
            fillMainTable();
        }

        private void dgvComplited_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex, dgvComplited))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dgvComplited.AdvancedCellBorderStyle.Top;
            }
        }

        private void dgvComplited_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex, dgvComplited))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        private void dgvComplited_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || dgvComplited[columnComplitedDocumentNumber.Index, e.RowIndex].Value == null) return;
            try
            {
                DocumentForm documentForm = new DocumentForm();
                string[] tableData = poaFileHandler.readFileData(dgvComplited[6, e.RowIndex].Value.ToString());
                POAElements poaElements = new POAElements(tableData[0]);

                documentForm = poaFileHandler.poaReading(tableData, poaElements);
                documentForm.Show();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Неможливо відкрити файл!\n" +
                                "Текст помилки: " + exception.Message, "Помилка", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvTemp.Rows.RemoveAt(dgvTemp.SelectedCells[0].RowIndex);
        }
    }
}
