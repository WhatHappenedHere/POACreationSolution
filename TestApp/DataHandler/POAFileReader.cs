using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp.DataHandler
{
    class POAFileReader
    {
        public DocumentForm poaReading(string[] tableData,POAElements poaElements)
        {
            DocumentForm documentForm = new DocumentForm();
            documentForm.fillTable(tableData);
            documentForm.fillFields(poaElements);
            return documentForm;
        }

        public string[] readTable(OpenFileDialog openFileDialog)
        {
            Stream openFileStream = null;
            if ((openFileStream = openFileDialog.OpenFile()) != null)
            {
                StreamReader streamReader = new StreamReader(openFileStream);
                try
                {                    
                    string[] tableDataString = streamReader.ReadToEnd().Split('\n');
                    return tableDataString;
                }
                catch (Exception exception)
                {
                    
                    MessageBox.Show("Помилка читання файлу!",exception.Message,MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    streamReader.Close();
                    openFileStream.Close();
                }
            }
            else
                return null;
        }
    }
}
