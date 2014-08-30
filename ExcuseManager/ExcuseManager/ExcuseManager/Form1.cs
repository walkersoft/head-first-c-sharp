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

namespace ExcuseManager
{
    public partial class Form1 : Form
    {
        Excuse currentExcuse;
        bool formChanged;
        string excusePath;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse = new Excuse();
            currentExcuse.LastUsed = date.Value;
            formChanged = false;
            excusePath = "";
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyDocuments;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                excusePath = folderBrowserDialog1.SelectedPath;
                currentExcuse.ExcusePath = excusePath;
                saveButton.Enabled = true;
                openButton.Enabled = true;
                randomButton.Enabled = true;
            }
        }

        private bool checkChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("You have unsaved changes. If you continue your changes will be lost. Proceed?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void saveExcuse()
        {
            currentExcuse.Save();
            MessageBox.Show("Excuse Written");
            updateForm(false);
        }

        private void updateForm(bool changed)
        {
            if (!changed)
            {
                this.excuseText.Text = currentExcuse.Description;
                this.resultsText.Text = currentExcuse.Results;
                this.date.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    dateTimeLabel.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                    this.Text = "Excuse Manager";
                }
            }
            else
            {
                this.Text = "Excuse Manager [*]";
            }
            this.formChanged = changed;
        }

        private void excuseText_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = excuseText.Text;
            updateForm(true);
        }

        private void resultsText_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = resultsText.Text;
            updateForm(true);
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = date.Value;
            updateForm(true);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (checkChanged())
            {
                currentExcuse.OpenFile(excusePath);
            }
            updateForm(false);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (checkChanged())
            {
                currentExcuse = new Excuse(random, excusePath);
            }
            updateForm(false);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(excuseText.Text) || String.IsNullOrEmpty(resultsText.Text))
            {
                MessageBox.Show("You must enter an excuse and a result.", "Cannot Save Excuse File");
                return;
            }
            saveExcuse();
            updateForm(false);
        }
    }
}
