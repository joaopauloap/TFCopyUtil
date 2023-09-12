using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFCopyUtil;

namespace TFUtil
{
    public partial class PreferenciasForm : Form
    {

        public PreferenciasForm()
        {
            InitializeComponent();
        }

        private void PreferenciasForm_Load(object sender, EventArgs e)
        {
            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (mainForm != null)
            {
                string cfgFileContent = mainForm.loadCfg();
                string[] lines = cfgFileContent.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                textBox1.Text = lines[0];
                textBox2.Text = lines[1];
                textBox3.Text = lines[2];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            using (StreamWriter writer = new StreamWriter("config.cfg"))
            {
                writer.Write($"{textBox1.Text}\n{textBox2.Text}\n{textBox3.Text}");
            }

            if (mainForm != null)
            {
                mainForm.loadCfg();
            }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != null)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != null)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.CheckFileExists)
            {
                textBox3.Text = openFileDialog1.FileName;
            }
        }
    }
}
