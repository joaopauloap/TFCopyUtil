using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TFUtil;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.LinkLabel;
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

        private void colorLine(int lineNumber, Color newColor)
        {
            string line = richTextBox1.Lines[lineNumber];
            int startIndex = richTextBox1.GetFirstCharIndexFromLine(lineNumber);
            int length = richTextBox1.Lines[lineNumber].Length;

            richTextBox1.Select(startIndex, length);
            richTextBox1.SelectionColor = newColor;
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void refreshLines()
        {
            int i = 0;
            foreach (string line in richTextBox1.Lines)
            {
                if (line.StartsWith("//"))
                    colorLine(i, Color.DarkGray);
                else
                    colorLine(i, Color.Black);
                i++;
            }
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
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
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
                refreshLines();
            }
            catch (FileNotFoundException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

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
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                }
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save Text File";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
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

        #region Radios
        private void localwkstRadio_Click(object sender, EventArgs e)
        {
            if (localwkstRadio.Checked)
            {
                destinationRootFolder = defaultClientPath + "\\localwkst";
                interpolarChk.Checked = true;
            }
        }

        private void exportLocalwkstRadio_Click(object sender, EventArgs e)
        {
            if (exportLocalwkstRadio.Checked)
            {
                interpolarChk.Checked = true;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    destinationRootFolder = folderBrowserDialog1.SelectedPath + "\\localwkst";
                }
            }
        }

        private void exportWorkspaceRadio_Click(object sender, EventArgs e)
        {
            if (exportWorkspaceRadio.Checked)
            {
                interpolarChk.Checked = false;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    destinationRootFolder = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        private void importBooksRadio_Click(object sender, EventArgs e)
        {
            if (importBooksRadio.Checked)
            {
                interpolarChk.Checked = false;
                interpolarChk.Enabled = false;

                destinationRootFolder = defaultWorkspacePath + "\\ARQ_PCCF\\resourcedata\\cobolcopys";
                openFileDialog1.FileName = "copybook.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] files = openFileDialog1.FileNames;

                    string fluxo = InputBox.Show("Informe o nome do fluxo:", "Nome do fluxo");

                    foreach (string fileName in files)
                    {
                        richTextBox1.AppendText($"\n{fluxo} {fileName}");
                    }
                }
            }
            else
            {
                interpolarChk.Enabled = true;
            }
        }
        #endregion

        #region Buttons
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
                //process.WaitForExit();
                Thread.Sleep(500);
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
                //process.WaitForExit();
                Thread.Sleep(500);
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
                //process.WaitForExit();
                Thread.Sleep(500);
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
            int lineNumber = -1;
            refreshLines();

            foreach (string line in richTextBox1.Lines)
            {
                lineNumber++;

                if (string.IsNullOrWhiteSpace(line)) continue;  //linha vazia
                if (line.StartsWith("//")) continue; //comentario

                string sourceFilePath = line;
                string relativePath = "";
                string destinationFilePath = "";

                if (interpolarChk.Checked)
                {
                    sourceFilePath = sourceFilePath.Replace("JavaSource", "output");
                    sourceFilePath = sourceFilePath.Replace(".java", ".class");
                }

                if (localwkstRadio.Checked)
                {
                    try
                    {
                        relativePath = sourceFilePath.Substring(sourceFilePath.IndexOf("com"));
                        destinationFilePath = Path.Combine(destinationRootFolder, relativePath);
                    }
                    catch (Exception ex)
                    {
                        if (relativePath == "")
                        {
                            MessageBox.Show($"Ocorreu um erro: Não foi encontrada uma estrutura de pastas compativel com a localwkst.");
                        }
                        else
                        {
                            MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                        }
                        return;
                    }
                }

                if (exportLocalwkstRadio.Checked)
                {
                    try
                    {
                        relativePath = sourceFilePath.Substring(sourceFilePath.IndexOf("com"));
                        destinationFilePath = Path.Combine(destinationRootFolder, relativePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                        return;
                    }
                }

                if (exportWorkspaceRadio.Checked)
                {
                    try
                    {
                        relativePath = sourceFilePath.Substring(sourceFilePath.IndexOf("workspaceFDDB"));
                        destinationFilePath = Path.Combine(destinationRootFolder, relativePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                        return;
                    }
                }

                if (importBooksRadio.Checked)
                {
                    try
                    {
                        string nomeFluxo = line.Split(" ")[0];
                        sourceFilePath = line.Split(" ")[1];
                        string filename = Path.GetFileNameWithoutExtension(sourceFilePath);
                        destinationFilePath = Path.Combine(destinationRootFolder, Path.Combine(nomeFluxo, filename + ".CPY"));

                        try
                        {
                            string destinationFwkFile = defaultWorkspacePath + "\\ARQ_PCCF\\JavaSource\\resourcedata\\fwk\\" + nomeFluxo + ".fwk";

                            using (StreamWriter writer = new StreamWriter(destinationFwkFile))
                            {
                                writer.Write($"root={nomeFluxo}\r\ninput=resourcedata/cobolcopys/{nomeFluxo}/{filename.Substring(0, filename.Length - 1) + "E"}.CPY\r\noutput=resourcedata/cobolcopys/{nomeFluxo}/{filename.Substring(0, filename.Length - 1) + "S"}.CPY");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                        }


                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        MessageBox.Show("Adicione o nome do fluxo antes do caminho da book, separando com um espaço. \n\nEx.:\nCTACIBA4 C:\\Users\\userName\\Desktop\\...");
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                        return;
                    }

                }

                try
                {

                    string origin = Path.GetDirectoryName(sourceFilePath);
                    string destinationFolder = Path.GetDirectoryName(destinationFilePath);
                    string filename = Path.GetFileNameWithoutExtension(sourceFilePath);

                    string[] files = Directory.GetFiles(origin)
                                                   .Where(f => Path.GetFileName(f).StartsWith(filename))
                                                   .ToArray();

                    Directory.CreateDirectory(destinationFolder);

                    if (files.Length > 1)
                    {
                        foreach (string file in files)
                        {
                            destinationFilePath = Path.Combine(destinationFolder, Path.GetFileName(file));
                            File.Copy(file, destinationFilePath, true);
                        }
                    }
                    else
                    {
                        File.Copy(sourceFilePath, destinationFilePath, true);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                    colorLine(lineNumber, Color.Red);
                    isSuccess = false;
                }
            }

            if (isSuccess)
            {
                MessageBox.Show($"Arquivos copiados com sucesso.");
                richTextBox1.Focus();
            }
            else
            {
                MessageBox.Show($"Alguns arquivos podem não ter sido copiados.");
                richTextBox1.Focus();
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
                //process.WaitForExit();
                Thread.Sleep(500);
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

    }
}