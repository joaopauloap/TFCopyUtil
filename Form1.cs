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

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                folderBrowserDialog1.ShowDialog();
                destinationRootFolder = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                destinationRootFolder = defaultClientPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string line in richTextBox1.Lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string sourceFilePath = line;

                if (checkBox1.Checked)
                {
                    sourceFilePath = sourceFilePath.Replace("JavaSource", "output");
                    sourceFilePath = sourceFilePath.Replace(".java", ".class");
                }

                try
                {
                    string relativePath = sourceFilePath.Substring(sourceFilePath.IndexOf("com"));
                    string destinationFilePath = Path.Combine(destinationRootFolder, relativePath);
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
            };

            using (Process process = new Process())
            {
                process.StartInfo = processInfo;
                process.Start();

                process.WaitForExit();
            }
        }
    }
}