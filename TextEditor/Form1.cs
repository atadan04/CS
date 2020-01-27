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

namespace TextEditor
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)//Open
        {
            textBox1.Text = "";
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            ReadFile(filePath);
            
        }

        
        private FileStream CreateFile(string filePath)
        {
            FileStream fs = File.Create(filePath);
            return fs;
            
        }
        private StreamWriter WriteToFile(string filePath)
        {
            FileStream fs = File.Open(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.WriteLine(filePath);
            return sw;
            
        }
        
        private void ReadFile(string filePath)
        {
            StreamReader sr;
            FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read);
            
            while (true)
            {
                sr = new StreamReader(fs, true);
                string output = sr.ReadLine();
                if (output==null)
                {
                    break;
                }
                textBox1.Text += output; 
            }
            sr.Close();
            fs.Close();
            fs = null;
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)//save
        {
            FileStream fs;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filePath = saveFileDialog1.FileName;
                fs = File.Open(filePath, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine(textBox1.Text);

                sw.Close();

            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
