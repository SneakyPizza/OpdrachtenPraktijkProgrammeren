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

namespace ReadWriteFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            string fname = tb_file.Text;
            string path = @"C:\Projects\C#Projects\AnalytischOntwerpen\OpdrachtenPraktijkProgrammeren\OpdrachtenPraktijkProgrammeren\" + fname + ".txt";

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                //TextWriter tw = new StreamWriter(path);
                //tw.WriteLine("The very first line!");
                //tw.Close();

                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine("The very first line!");
                    tw.Close();
                }
                lbl_file.Text = "tekst file " + fname + " is aangemaakt";

            } else if(File.Exists(path))
            {
                //TextWriter tw = new StreamWriter(path);
                using(TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine("new line added");
                    tw.Close();
                }
                lbl_file.Text = fname + " bestaat al, nieuwe regel toegevoegd";
            }
        }

        private void btn_dir_Click(object sender, EventArgs e)
        {
            string dname = tb_dir.Text;
            
            if(dname != String.Empty)
            {
                Directory.CreateDirectory(dname);
                if (Directory.Exists(dname))
                {
                    lbl_dir.Text = "Directory " + dname + " is aangemaakt";
                }
            }
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            string fname = tb_counting.Text;

            if(fname != null)
            {
                
            } else
            {
                lbl_counting.Text = "Error no input";
            }
        }
    }
}
