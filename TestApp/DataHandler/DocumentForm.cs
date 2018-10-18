using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.DataHandler;

namespace TestApp
{
    public partial class DocumentForm : Form
    {
        public DocumentForm()
        {
            InitializeComponent();
        }
        public void changeLable(String name)
        {
            lbDateOfIssue.Text = name;
        }

        public void fillFields(POAElements poaElements)
        {
            dtpDateOfIssue.Value = poaElements.dateOfIssue;
            dtpDocumentDate.Value = poaElements.documentDate;
            dtpExpirationDate.Value = poaElements.expirationDate;
            tbOrder.Text = poaElements.order;
            tbDocumentNumber.Text = poaElements.documentNumber.ToString();
            tbPersonDocumentNumber.Text = poaElements.personsDocumentNumber.ToString();
            tbRecipient.Text = poaElements.recipient;
            tbPayer.Text = poaElements.payer;
            tbIssuedByPerson.Text = poaElements.issuedToPerson;
            cbDocumentType.Text = poaElements.documentType;
            tbSeries.Text = poaElements.series;
            tbPersonDocumentDate.Text = poaElements.personsDocumentDate;
            tbIssuedByOrganization.Text = poaElements.personsDocumentIssuedOrganization;
            tbProvider.Text = poaElements.provider;
        }

        public void fillTable(string[] tableData)
        {
            string[] stringData;
            string[] refactoredData=new string[4];
            for (int i=1;i<tableData.Count() - 1;i++)
            {
                stringData = tableData[i].Split('^');
                for(int j = 0; j<4; j++)
                  refactoredData[j] = stringData[j].Replace("[symbol]", "^");
                dgvPOAData.Rows.Add(refactoredData[0], refactoredData[1], refactoredData[2], refactoredData[3]);
            }
        }

        private string concatenateString()
        {
            string textForFile = dtpDateOfIssue.Text + "☼" + dtpExpirationDate.Text +
                            "☼" + tbDocumentNumber.Text + "☼" + dtpDocumentDate.Text + "☼" + tbRecipient.Text + "☼" +
                            tbPayer.Text + "☼" + tbIssuedByPerson.Text + "☼" + cbDocumentType.Text + "☼" +
                            tbSeries.Text + "☼" + tbPersonDocumentNumber.Text + "☼" + tbPersonDocumentDate.Text +
                            "☼" + tbIssuedByOrganization.Text + "☼" + tbProvider.Text + "☼" + tbOrder.Text+"\n";
            for (int i = 0; i < dgvPOAData.RowCount - 1; i++)
            {
                for (int j = 0; j < dgvPOAData.ColumnCount; j++)
                {
                    string data = dgvPOAData.Rows[i].Cells[j].Value.ToString().Replace("^", "[symbol]");
                    data += "^";
                    textForFile += data;
                }
                textForFile += "\n";
            }
            return textForFile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialogPOA.Filter = "poa files (*.poa)|*.poa|All files (*.*)|*.*";
            saveFileDialogPOA.Title = "Зберегти як";
            Stream dataStream;
            if(saveFileDialogPOA.ShowDialog() == DialogResult.OK)
            {
                if((dataStream = saveFileDialogPOA.OpenFile())!=null)
                {
                    StreamWriter streamWriter = new StreamWriter(dataStream);
                    StreamWriter streamBaseWriter = new StreamWriter("./DataBaseImitation.txt",true);
                    string textForFile;

                    //baseStream = ; 
                    try
                    {
                        textForFile = concatenateString();
                        streamWriter.Write(textForFile);
                        streamBaseWriter.WriteLine(textForFile+"\n----------------------------------------");
                        
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show("Помилка запису файла!" +
                                    "Текст помилки: " + exception.Message, "Помилка", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    }
                    finally
                    {
                        streamBaseWriter.Close();
                        streamWriter.Close();
                        dataStream.Close();
                    }
                }
            }
        }

        private void btFillTable_Click(object sender, EventArgs e)
        {
            string resoursType = tbType.Text;
            string resoursAmount = tbAmount.Text;
            string resoursMeasurementUnit = tbMeasurementUnit.Text;
            if (resoursType == "" || resoursAmount == "" || resoursMeasurementUnit == "")
                MessageBox.Show("Заповніть будь ласка всі поля форми!");
            else
            {
                tbType.Text = "";
                tbAmount.Text = "";
                tbMeasurementUnit.Text = "";
                dgvPOAData.Rows.Add(dgvPOAData.RowCount, resoursType, resoursMeasurementUnit, resoursAmount);
            }
        }

        private void btDeleteSelectedRow_Click(object sender, EventArgs e)
        {
            int removeIndex = dgvPOAData.SelectedCells[0].RowIndex;
            dgvPOAData.Rows.RemoveAt(removeIndex);
        }
    }
}
