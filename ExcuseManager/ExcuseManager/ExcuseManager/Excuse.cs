using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ExcuseManager
{
    public class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public string ExcusePath { get; set; }
        public DateTime LastUsed { get; set; }

        public Excuse()
        {
            Description = "";
            Results = "";
            ExcusePath = "";
            LastUsed = DateTime.Now;
        }

        public Excuse(string open)
        {
            OpenFile(open);
        }

        public Excuse(Random random, string open)
        {
            ExcusePath = open;
            string[] files = Directory.GetFiles(open);
            string file = files[random.Next(files.Length)];
            using (StreamReader sr = new StreamReader(file))
            {
                Description = sr.ReadLine();
                Results = sr.ReadLine();
                LastUsed = Convert.ToDateTime(sr.ReadLine());
            }
        }

        public void OpenFile(string path) 
        {
            ExcusePath = path;
            OpenFileDialog opener = new OpenFileDialog();
            opener.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            opener.InitialDirectory = ExcusePath;
            DialogResult openFile = opener.ShowDialog();
            if (openFile == DialogResult.OK)
            {
                string of = opener.FileName;
                using (StreamReader sr = new StreamReader(of))
                {
                    Description = sr.ReadLine();
                    Results = sr.ReadLine();
                    LastUsed = Convert.ToDateTime(sr.ReadLine());
                }
            }
        }

        public void Save() 
        {
            SaveFileDialog saver = new SaveFileDialog();
            saver.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saver.InitialDirectory = ExcusePath;
            DialogResult saveFile = saver.ShowDialog();
            if (saveFile == DialogResult.OK)
            {
                string sf = saver.FileName;
                using (StreamWriter sw = new StreamWriter(sf))
                {
                    sw.WriteLine(Description);
                    sw.WriteLine(Results);
                    sw.WriteLine(LastUsed.ToString());
                }
            }
        }
    }
}
