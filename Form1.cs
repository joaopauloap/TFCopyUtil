using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace TFCopyUtil
{
    public partial class Form1 : Form
    {
        static string defaultClientPath = @"C:\CLIENT\";
        string destinationRootFolder = defaultClientPath + "localwkst";
        AboutBox1 aboutBox1 = new AboutBox1();

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                destinationRootFolder = defaultClientPath;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                folderBrowserDialog1.ShowDialog();
                destinationRootFolder = folderBrowserDialog1.SelectedPath;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                folderBrowserDialog1.ShowDialog();
                destinationRootFolder = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string line in richTextBox1.Lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string sourceFilePath = line;
                string relativePath = sourceFilePath.Substring(sourceFilePath.IndexOf("com"));
                string destinationFilePath = Path.Combine(destinationRootFolder, relativePath);

                if (checkBox1.Checked)
                {
                    sourceFilePath = sourceFilePath.Replace("JavaSource", "output");
                    sourceFilePath = sourceFilePath.Replace(".java", ".class");
                }

                if (radioButton3.Checked)
                {
                    relativePath = sourceFilePath.Substring(sourceFilePath.IndexOf("workspaceFDDB"));
                    destinationFilePath = Path.Combine(destinationRootFolder, relativePath);
                }

                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(destinationFilePath));
                    File.Copy(sourceFilePath, destinationFilePath, true);

                    MessageBox.Show($"Arquivos copiados com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string filePath = @"C:\CLIENT\client.js";
            string arguments = @"-a INTE -p TerminalFinanceiro -x -d";

            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                WorkingDirectory = defaultClientPath,
                FileName = "cscript",
                Arguments = $@"{filePath} {arguments}",
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = processInfo;
                Cursor.Current = Cursors.WaitCursor;
                process.Start();
                process.WaitForExit();
                Cursor.Current = Cursors.Default;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox1.Show();
        }

    }
}