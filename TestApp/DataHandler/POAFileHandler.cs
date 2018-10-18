using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp.DataHandler
{
    class POAFileHandler
    {
        public DocumentForm poaReading(string[] tableData,POAElements poaElements)
        {
            DocumentForm documentForm = new DocumentForm();
            documentForm.fillTable(tableData);
            documentForm.fillFields(poaElements);
            return documentForm;
        }

        public string[] readFileData(Stream openFileStream)
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

        public void writeIntoUserFile(string textForFile,Stream dataStream)
        {
            StreamWriter streamWriter = new StreamWriter(dataStream);
            try
            {
                streamWriter.Write(textForFile);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Помилка збереження файла!" +
                            "Текст помилки: " + exception.Message, "Помилка", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            finally
            {
                streamWriter.Close();
            }
        }

        public void writeIntoBase(string textForFile,Stream dataStream)
        {
            
            StreamWriter streamBaseWriter = new StreamWriter("./DataBaseImitation.txt", true);
            
            try
            {
                streamBaseWriter.WriteLine(textForFile + "\n----------------------------------------");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Помилка збереження даних довіреності!" +
                            "Текст помилки: " + exception.Message, "Помилка", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            finally
            {
                streamBaseWriter.Close();
            }
        }



        public string[] readFromDialog(OpenFileDialog openFileDialog)
        {
            Stream openFileStream = null;
            try
            {
                if ((openFileStream = openFileDialog.OpenFile()) != null)
                {
                    return readFileData(openFileStream);
                }
                else
                    return null;
            }
            catch(Exception exception)
            {

                MessageBox.Show("Помилка читання файлу!", exception.Message, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
            finally
            {               
                openFileStream.Close();
            }
        }
    }
}
