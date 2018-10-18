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

        private void dgvTemp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int poeNumber = (int)dgvTemp[0, e.RowIndex].Value;

        }
    }
}
