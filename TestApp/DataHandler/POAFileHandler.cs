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

        public string[] loadBaseData()
        {
            StreamWriter streamCheck = new StreamWriter("./DataBaseImitation.txt",true);
            var fi = new FileInfo("./DataBaseImitation.txt");
            if (fi.Length == 0)
            {
                streamCheck.Close();
                return null;
            }
            else
            {
                streamCheck.Close();
                StreamReader streamReader = new StreamReader("./DataBaseImitation.txt");
                try
                {
                    string[] tableDataString = streamReader.ReadToEnd().Split('œ');
                    return tableDataString;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Помилка завантаження інформації про " +
                                    "створенні довіреності!", exception.Message,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally { streamReader.Close(); }
            }   
                
        }

        public Dictionary<int,string[]> dividePOAs(string[] loadedData)
        {
            Dictionary<int, string[]> dividedData = new Dictionary<int, string[]>();
            for(int i=0;i<loadedData.Length;i++)
            {
                dividedData.Add(i, divideByNewLine(loadedData[i]));
            }
            return dividedData;
        }

        public string[] divideByNewLine(string text)
        {
            return text.Split('\n');
        }

        public string[] divideBySymbol(string text)
        {
            return text.Split('☼');
        }

        public string[] readFileData(Stream fileStream)
        {
            
                StreamReader streamReader = new StreamReader(fileStream);
                try
                {                    
                    string[] tableDataString = divideByNewLine(streamReader.ReadToEnd());
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
                }
            
        }

        public string[] readFileData(string fileStream)
        {

            StreamReader streamReader = new StreamReader(fileStream);
            try
            {
                string[] tableDataString = divideByNewLine(streamReader.ReadToEnd());
                return tableDataString;
            }
            catch (Exception exception)
            {

                MessageBox.Show("Помилка читання файлу!", exception.Message, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                streamReader.Close();
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

        public void writeIntoBase(string textForFile, string fileName)//Stream dataStream,string fileName)
        {
            
            StreamWriter streamBaseWriter = new StreamWriter("./DataBaseImitation.txt", true);
            
            try
            {
                streamBaseWriter.Write(fileName + "\n");
                string[] baseDataString = textForFile.Split('\n');
                POAElements poaElements = new POAElements(baseDataString[0]);

                string[] stringData;
                string[] refactoredData = new string[4];
                for (int i = 1; i < baseDataString.Count() - 1; i++)
                {
                    stringData = baseDataString[i].Split('^');
                    for (int j = 0; j < 4; j++)
                        refactoredData[j] = stringData[j].Replace("[symbol]", "^");

                    streamBaseWriter.Write(refactoredData[1] + "☼" + refactoredData[3]);
                    if (i != baseDataString.Count() - 2)
                    {
                        streamBaseWriter.Write("☼");
                    }
                }

                streamBaseWriter.Write("\n");
                

                streamBaseWriter.WriteLine(poaElements.documentNumber); 
                streamBaseWriter.WriteLine(poaElements.dateOfIssue);
                streamBaseWriter.WriteLine(poaElements.expirationDate);
                streamBaseWriter.Write("œ");

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
