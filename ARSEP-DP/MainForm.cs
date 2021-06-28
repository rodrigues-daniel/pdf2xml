using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ARSEP_DP
{


    public partial class MainForm : Form
    {
        string fileContent = string.Empty;
        string filePath = string.Empty;
        public MainForm()
        {
            InitializeComponent();        }

      

        private void findPDF_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void sle01_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);


        }
    }
}
