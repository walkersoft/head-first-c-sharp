using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|" + "Comma-Delimited Files (*.csv)|*.csv|AllFiles (*.*)|*.*";
            openFileDialog1.FileName = "default_file.txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("YOu clicked OK!");
                MessageBox.Show("Init Dir: " + Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Text Files (*.txt)|.txt|HTML Files (*.html)|*.html";
            DialogResult saveable = saveFileDialog1.ShowDialog();
            if (saveable == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }
    }
}
