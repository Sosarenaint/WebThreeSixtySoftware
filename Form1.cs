using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebThreeSixty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.Title = "Where to save the file?";
            //saveFileDialog1.CheckFileExists = true;
            //saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "wts";
            saveFileDialog1.Filter = "WebThreeSixty (*.wts)|*.wts";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string tambahan = this.textBox1.Text;
                string text = "Ini adalah teks yang ditulis... Plus ini: " + tambahan;
                string projectName = saveFileDialog1.FileName;
                string projectFolder = projectName.Remove(projectName.Length - 4);
                MessageBox.Show(projectFolder, "Great!");
                if (!Directory.Exists(projectFolder))
                {
                    File.WriteAllText(projectName, text);
                    Directory.CreateDirectory(projectFolder);
                    string message = "File has been created.";
                    MessageBox.Show(message, "Great!");
                }

                
                
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
