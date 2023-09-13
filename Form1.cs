using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TFUtil;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TFCopyUtil
{
    public partial class Form1 : Form
    {
        static string defaultClientPath = @"C:\CLIENT";
        static string defaultWorkspacePath = @"C:\workspaceFDDB";
        static string defaultEditorPath = @"C:\Windows\notepad.exe";
        string destinationRootFolder;

        AboutBox1 aboutBox1 = new AboutBox1();

        public Form1()
        {
            InitializeComponent();
            richTextBox1.DragDrop += new DragEventHandler(richTextBox1_DragDrop);
            richTextBox1.AllowDrop = true;
        }

        public string loadCfg()
        {
            string cfgFileContent = "";

            try
            {
                cfgFileContent = File.ReadAllText("config.cfg");
            }
            catch (FileNotFoundException ex)
            {
                using (StreamWriter writer = new StreamWriter("config.cfg"))
                {
                    cfgFileContent = "C:\\CLIENT\nC:\\workspaceFDDB\nC:\\Windows\\notepad.exe";
                    writer.Write(cfgFileContent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro: " + ex.Message);
            }
            finally
            {
                string[] lines = cfgFileContent.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                defaultClientPath = lines[0];
                defaultWorkspacePath = lines[1];
                defaultEditorPath = lines[2];
            }

            return cfgFileContent;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guardarCaminhosChk.Checked)
            {
                File.WriteAllText("paths.txt", richTextBox1.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCfg();

            destinationRootFolder = defaultClientPath + "\\localwkst";

            try
            {
                richTextBox1.Text = File.ReadAllText("paths.txt");
            }
            catch (FileNotFoundException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro: " + ex.Message);
            }
        }

        #region Menu Superior

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox1.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            openFileDialog1.Title = "Open Text File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um Erro: " + ex.Message);
                }
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save Text File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(richTextBox1.Text);
                }
            }
        }

        private void preferênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferenciasForm preferenciasForm = new PreferenciasForm();
            preferenciasForm.Show();
        }

        private void manualDoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);

        }

        #endregion

        private void richTextBox1_DragDrop(object? sender, DragEventArgs e)
        {
            object files = e.Data.GetData("FileDrop");
            if (files != null)
            {
                var list = files as string[];
                foreach (string fileName in list)
                {
                    richTextBox1.AppendText("\n" + fileName);
                }
            }
        }

        #region Radios Check
        private void localwkstRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (localwkstRadio.Checked)
            {
                destinationRootFolder = defaultClientPath + "\\localwkst";
                interpolarChk.Checked = true;
            }
        }

        private void exportLocalwkstRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (exportLocalwkstRadio.Checked)
            {
                interpolarChk.Checked = true;
                folderBrowserDialog1.ShowDialog();
                destinationRootFolder = folderBrowserDialog1.SelectedPath + "\\localwkst";
            }
        }

        private void exportWorkspaceRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (exportWorkspaceRadio.Checked)
            {
                interpolarChk.Checked = false;
                folderBrowserDialog1.ShowDialog();
                destinationRootFolder = folderBrowserDialog1.SelectedPath;
            }
        }
        #endregion

        #region Buttons Click
        private void localwkstBtn_Click(object sender, EventArgs e)
        {
            string path = @$"{defaultClientPath}\localwkst";

            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                WorkingDirectory = defaultClientPath,
                FileName = "explorer",
                Arguments = path,
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

        private void workspaceBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                WorkingDirectory = defaultClientPath,
                FileName = "explorer",
                Arguments = defaultWorkspacePath,
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

        private void logBtn_Click(object sender, EventArgs e)
        {
            string filePath = @$"{defaultClientPath}\INTE\TerminalFinanceiro\log\bradesco.log";

            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                WorkingDirectory = defaultClientPath,
                FileName = defaultEditorPath,
                Arguments = filePath,
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

        private void killtfBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("jps", "-ml");
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            string[] output = p.StandardOutput.ReadToEnd().Split("\n".ToCharArray());

            foreach (string proc in output)
            {
                if (proc != "")
                {
                    int procId = int.Parse(proc.Split(" ")[0]);
                    string procName = proc.Split(" ")[1];

                    if (procName == "br.com.bradesco.branch.startup.SystemStartup")
                    {
                        Process.GetProcessById(procId, ".").Kill(true);
                    }
                }
            }

        }

        private void transferirBtn_Click(object sender, EventArgs e)
        {
            bool isSuccess = true;

            foreach (string line in richTextBox1.Lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string sourceFilePath = line;
                string relativePath;
                string destinationFilePath = "";

                if (interpolarChk.Checked)
                {
                    sourceFilePath = sourceFilePath.Replace("JavaSource", "output");
                    sourceFilePath = sourceFilePath.Replace(".java", ".class");
                }

                if (localwkstRadio.Checked)
                {
                    relativePath = sourceFilePath.Substring(sourceFilePath.IndexOf("com"));
                    destinationFilePath = Path.Combine(destinationRootFolder, relativePath);
                }
                if (exportLocalwkstRadio.Checked)
                {
                    relativePath = sourceFilePath.Substring(sourceFilePath.IndexOf("com"));
                    destinationFilePath = Path.Combine(destinationRootFolder, relativePath);
                }
                if (exportWorkspaceRadio.Checked)
                {
                    relativePath = sourceFilePath.Substring(sourceFilePath.IndexOf("workspaceFDDB"));
                    destinationFilePath = Path.Combine(destinationRootFolder, relativePath);
                }

                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(destinationFilePath));
                    File.Copy(sourceFilePath, destinationFilePath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                    isSuccess = false;
                }
            }

            if (isSuccess)
            {
                MessageBox.Show($"Arquivos copiados com sucesso.");
            }
            else
            {
                MessageBox.Show($"Alguns arquivos podem não ter sido copiados.");
            }
        }

        private void tfBtn_Click(object sender, EventArgs e)
        {

            string filePath = @$"{defaultClientPath}\client.js";
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
        #endregion
    }
}