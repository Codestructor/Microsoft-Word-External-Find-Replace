using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;
using System.Diagnostics;

namespace Word
{
    public partial class PrimeForm : Form
    {
        public PrimeForm()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(PrimeForm_DragEnter);
            this.DragDrop += new DragEventHandler(PrimeForm_DragDrop);
        }

        IEnumerable<FileInfo> fileList;
        string buffer;
        int filesOpened = 0, nrDocs = 0, oldValue = 0, intervalProgressBar = 15;

        private void findAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findText, object replaceText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike,
                ref matchAllWordForms, ref forward,
                ref wrap, ref format, ref replaceText,
                ref replace, ref matchKashida,
                ref matchDiacritics, ref matchAlefHamza,
                ref matchControl);
        }

        private void changeWordDocument(object fileName, object findText, object replaceText)
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("WINWORD"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problems at closing processes");
            }

            object missing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document aDoc = null;
            object doNotSaveChanges = Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges;

            buffer += "Opening file: " + Environment.NewLine + (string)fileName + Environment.NewLine;

            if (File.Exists((string)fileName))
            {
                buffer += ".....File opened" + Environment.NewLine;

                object readOnly = false;
                object isVisible = false;

                wordApp.Visible = false;

                aDoc = wordApp.Documents.Open(ref fileName, ref missing,
                ref readOnly, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref isVisible, ref missing, ref missing,
                ref missing, ref missing);

                aDoc.Activate();

                findAndReplace(wordApp, findText, replaceText);

                var shapes = aDoc.Shapes;

                foreach (Shape shape in shapes)
                {
                    try
                    {
                        var initialText = shape.TextFrame.TextRange.Text;
                        var resultingText = initialText.Replace((string)findText, (string)replaceText);
                        shape.TextFrame.TextRange.Text = resultingText;
                    }
                    catch (Exception exp) { }
                }

            }
            else
            {
                buffer += ".....File does not exist." + Environment.NewLine;
                return;
            }

            string fullName = aDoc.FullName;
            object fullFileName;

            if (fullName.Contains((string)findText))
            {
                //buffer += "....." + fullName + Environment.NewLine;
                fullName = fullName.Replace((string)findText, (string)replaceText);
                buffer += "....." + "Name changed" + Environment.NewLine + fullName + Environment.NewLine;
            }

            fullFileName = fullName;

            aDoc.SaveAs2(ref fullFileName,
    ref missing, ref missing, ref missing, ref missing, ref missing,
    ref missing, ref missing, ref missing, ref missing, ref missing,
    ref missing, ref missing, ref missing, ref missing, ref missing);

            aDoc.Close(ref doNotSaveChanges, ref missing, ref missing);

            /*if ((string)fileName != fullName)
            {
                File.Delete((string)fileName);
                buffer += ".....Deleted: " + Environment.NewLine + fileName + Environment.NewLine;
            }*/

            Marshal.ReleaseComObject(wordApp);

            buffer += "....." + "Saved successfully" + Environment.NewLine + fullName + Environment.NewLine;
        }

        private void threadMethod()
        {
            buffer = "Process Started" + Environment.NewLine;

            try
            {
                foreach (FileInfo file in fileList)
                {
                    try
                    {
                        if ((file.Extension == ".doc" || file.Extension == ".docx") && !(file.Name[0] == '~' && file.Name[1] == '$'))
                        {
                            changeWordDocument(file.FullName, findTextTxtBox.Text, replaceTextTxtBox.Text);
                            filesOpened++;
                            //progressTxtBox
                        }
                    }
                    catch (Exception exception)
                    {
                        buffer += ".....File is corrupted." + Environment.NewLine;
                    }
                }

                buffer += "Process finished successfully." + Environment.NewLine;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception: " + exception.ToString() + "\nPlease fill all text boxes.");
            }

            try
            {
                foreach (Process proc in Process.GetProcessesByName("WINWORD"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problems at closing processes");
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (pathTxtBox.Text == "" || findTextTxtBox.Text == "" || replaceTextTxtBox.Text == "")
            {
                progressTxtBox.Text = "Please fill all fields";
                return;
            }

            

            if (!Directory.Exists(pathTxtBox.Text))
            {
                progressTxtBox.Text = "Invalid path";
                return;
            }

            DirectoryInfo dir = new DirectoryInfo(pathTxtBox.Text);            

            progressTxtBox.Text = "";

            if (allRadioBtn.Checked)
                fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
            else
                fileList = dir.GetFiles("*.*", SearchOption.TopDirectoryOnly);

            foreach (FileInfo file in fileList)
            {
                if ((file.Extension == ".doc" || file.Extension == ".docx") && !(file.Name[0] == '~' && file.Name[1] == '$'))
                {
                    nrDocs++;
                }
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = nrDocs * intervalProgressBar;

            Thread thr = new Thread(threadMethod);
            thr.Start();

            timer1.Start();

            /*progressTxtBox.Find("File is corrupted.");
            progressTxtBox.SelectionColor = Color.Red;*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressTxtBox.Text += buffer;
            buffer = "";
            if (oldValue == filesOpened)
                progressBar1.Increment(1);
            else
            {
                oldValue = filesOpened;
                progressBar1.Value = filesOpened * intervalProgressBar;
            }

            if (filesOpened >= nrDocs)
            {
                int startIndex = 0;
                string word = "File is corrupted.";
                while (startIndex < progressTxtBox.TextLength)
                {
                    int wordStartIndex = progressTxtBox.Find(word, startIndex, RichTextBoxFinds.None);

                    if (wordStartIndex != -1)
                    {
                        progressTxtBox.SelectionStart = wordStartIndex;
                        progressTxtBox.SelectionLength = word.Length;
                        progressTxtBox.SelectionColor = Color.Red;
                    }
                    else
                        break;
                    startIndex += wordStartIndex + word.Length;
                }

                timer1.Stop();
            }
        }

        private void PrimeForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            pathTxtBox.Text = files[0];
        }

        private void PrimeForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }
}
