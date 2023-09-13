namespace TFCopyUtil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            exportWorkspaceRadio = new RadioButton();
            localwkstRadio = new RadioButton();
            exportLocalwkstRadio = new RadioButton();
            label1 = new Label();
            panel3 = new Panel();
            guardarCaminhosChk = new CheckBox();
            label2 = new Label();
            interpolarChk = new CheckBox();
            splitContainer2 = new SplitContainer();
            transferirBtn = new Button();
            tfBtn = new Button();
            panel4 = new Panel();
            killtfBtn = new Button();
            workspaceBtn = new Button();
            localwkstBtn = new Button();
            logBtn = new Button();
            label3 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            preferênciasToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            manualDoUsuárioToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            helpProvider1 = new HelpProvider();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel4.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(987, 544);
            splitContainer1.SplitterDistance = 716;
            splitContainer1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.AllowDrop = true;
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(712, 540);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(splitContainer2, 0, 3);
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 157F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.Size = new Size(263, 540);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(exportWorkspaceRadio);
            panel1.Controls.Add(localwkstRadio);
            panel1.Controls.Add(exportLocalwkstRadio);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 161);
            panel1.TabIndex = 10;
            // 
            // exportWorkspaceRadio
            // 
            exportWorkspaceRadio.AutoSize = true;
            exportWorkspaceRadio.Location = new Point(10, 111);
            exportWorkspaceRadio.Name = "exportWorkspaceRadio";
            exportWorkspaceRadio.Size = new Size(240, 29);
            exportWorkspaceRadio.TabIndex = 11;
            exportWorkspaceRadio.Text = "Exportar WorkspaceFDDB";
            exportWorkspaceRadio.UseVisualStyleBackColor = true;
            exportWorkspaceRadio.CheckedChanged += exportWorkspaceRadio_CheckedChanged;
            // 
            // localwkstRadio
            // 
            localwkstRadio.AutoSize = true;
            localwkstRadio.Checked = true;
            localwkstRadio.Location = new Point(10, 41);
            localwkstRadio.Name = "localwkstRadio";
            localwkstRadio.Size = new Size(245, 29);
            localwkstRadio.TabIndex = 10;
            localwkstRadio.TabStop = true;
            localwkstRadio.Text = "Bradesco Client (localwkst)";
            localwkstRadio.UseVisualStyleBackColor = true;
            localwkstRadio.CheckedChanged += localwkstRadio_CheckedChanged;
            // 
            // exportLocalwkstRadio
            // 
            exportLocalwkstRadio.AutoSize = true;
            exportLocalwkstRadio.Location = new Point(10, 76);
            exportLocalwkstRadio.Name = "exportLocalwkstRadio";
            exportLocalwkstRadio.Size = new Size(180, 29);
            exportLocalwkstRadio.TabIndex = 8;
            exportLocalwkstRadio.Text = "Exportar localwkst";
            exportLocalwkstRadio.UseVisualStyleBackColor = true;
            exportLocalwkstRadio.CheckedChanged += exportLocalwkstRadio_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 9;
            label1.Text = "Destino";
            // 
            // panel3
            // 
            panel3.Controls.Add(guardarCaminhosChk);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(interpolarChk);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 134);
            panel3.TabIndex = 12;
            // 
            // guardarCaminhosChk
            // 
            guardarCaminhosChk.AutoSize = true;
            guardarCaminhosChk.Checked = true;
            guardarCaminhosChk.CheckState = CheckState.Checked;
            guardarCaminhosChk.Location = new Point(10, 80);
            guardarCaminhosChk.Name = "guardarCaminhosChk";
            guardarCaminhosChk.Size = new Size(182, 29);
            guardarCaminhosChk.TabIndex = 15;
            guardarCaminhosChk.Text = "Guardar caminhos";
            guardarCaminhosChk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 13;
            label2.Text = "Opções";
            // 
            // interpolarChk
            // 
            interpolarChk.AutoSize = true;
            interpolarChk.Checked = true;
            interpolarChk.CheckState = CheckState.Checked;
            interpolarChk.Location = new Point(10, 45);
            interpolarChk.Name = "interpolarChk";
            interpolarChk.Size = new Size(197, 29);
            interpolarChk.TabIndex = 14;
            interpolarChk.Text = "Interpolar saída java";
            interpolarChk.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(5, 475);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(transferirBtn);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tfBtn);
            splitContainer2.Size = new Size(253, 60);
            splitContainer2.SplitterDistance = 178;
            splitContainer2.TabIndex = 11;
            // 
            // transferirBtn
            // 
            transferirBtn.Cursor = Cursors.Hand;
            transferirBtn.Dock = DockStyle.Fill;
            transferirBtn.Location = new Point(0, 0);
            transferirBtn.Name = "transferirBtn";
            transferirBtn.Size = new Size(178, 60);
            transferirBtn.TabIndex = 0;
            transferirBtn.Text = "Transferir Arquivos";
            transferirBtn.UseVisualStyleBackColor = true;
            transferirBtn.Click += transferirBtn_Click;
            // 
            // tfBtn
            // 
            tfBtn.BackgroundImage = TFUtil.Properties.Resources.bradesco;
            tfBtn.BackgroundImageLayout = ImageLayout.Stretch;
            tfBtn.Cursor = Cursors.Hand;
            tfBtn.Dock = DockStyle.Fill;
            tfBtn.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            tfBtn.ForeColor = Color.White;
            tfBtn.Location = new Point(0, 0);
            tfBtn.Name = "tfBtn";
            tfBtn.Size = new Size(71, 60);
            tfBtn.TabIndex = 0;
            tfBtn.Text = "TF";
            tfBtn.UseVisualStyleBackColor = true;
            tfBtn.Click += tfBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(killtfBtn);
            panel4.Controls.Add(workspaceBtn);
            panel4.Controls.Add(localwkstBtn);
            panel4.Controls.Add(logBtn);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 316);
            panel4.Name = "panel4";
            panel4.Size = new Size(253, 151);
            panel4.TabIndex = 13;
            // 
            // killtfBtn
            // 
            killtfBtn.Location = new Point(129, 89);
            killtfBtn.Name = "killtfBtn";
            killtfBtn.Size = new Size(106, 34);
            killtfBtn.TabIndex = 20;
            killtfBtn.Text = "kill TF";
            killtfBtn.UseVisualStyleBackColor = true;
            killtfBtn.Click += killtfBtn_Click;
            // 
            // workspaceBtn
            // 
            workspaceBtn.Location = new Point(129, 49);
            workspaceBtn.Name = "workspaceBtn";
            workspaceBtn.Size = new Size(106, 34);
            workspaceBtn.TabIndex = 19;
            workspaceBtn.Text = "workspace";
            workspaceBtn.UseVisualStyleBackColor = true;
            workspaceBtn.Click += workspaceBtn_Click;
            // 
            // localwkstBtn
            // 
            localwkstBtn.Location = new Point(17, 49);
            localwkstBtn.Name = "localwkstBtn";
            localwkstBtn.Size = new Size(106, 34);
            localwkstBtn.TabIndex = 18;
            localwkstBtn.Text = "localwkst";
            localwkstBtn.UseVisualStyleBackColor = true;
            localwkstBtn.Click += localwkstBtn_Click;
            // 
            // logBtn
            // 
            logBtn.Location = new Point(17, 89);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(106, 34);
            logBtn.TabIndex = 17;
            logBtn.Text = "log";
            logBtn.UseVisualStyleBackColor = true;
            logBtn.Click += logBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 5);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 16;
            label3.Text = "Atalhos";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripDropDownButton2, toolStripDropDownButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(987, 34);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, salvarComoToolStripMenuItem, toolStripSeparator2, sairToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(93, 29);
            toolStripDropDownButton1.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(227, 34);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(227, 34);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salvarComoToolStripMenuItem
            // 
            salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            salvarComoToolStripMenuItem.Size = new Size(227, 34);
            salvarComoToolStripMenuItem.Text = "Salvar Como...";
            salvarComoToolStripMenuItem.Click += salvarComoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(224, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(227, 34);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { preferênciasToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(75, 29);
            toolStripDropDownButton2.Text = "Editar";
            // 
            // preferênciasToolStripMenuItem
            // 
            preferênciasToolStripMenuItem.Name = "preferênciasToolStripMenuItem";
            preferênciasToolStripMenuItem.Size = new Size(208, 34);
            preferênciasToolStripMenuItem.Text = "Preferências";
            preferênciasToolStripMenuItem.Click += preferênciasToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { manualDoUsuárioToolStripMenuItem, toolStripSeparator1, sobreToolStripMenuItem });
            toolStripDropDownButton3.Image = (Image)resources.GetObject("toolStripDropDownButton3.Image");
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(76, 29);
            toolStripDropDownButton3.Text = "Ajuda";
            // 
            // manualDoUsuárioToolStripMenuItem
            // 
            manualDoUsuárioToolStripMenuItem.Name = "manualDoUsuárioToolStripMenuItem";
            manualDoUsuárioToolStripMenuItem.Size = new Size(264, 34);
            manualDoUsuárioToolStripMenuItem.Text = "Manual do Usuário";
            manualDoUsuárioToolStripMenuItem.Click += manualDoUsuárioToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(261, 6);
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(264, 34);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 544);
            panel2.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "manual.html";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 578);
            Controls.Add(panel2);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            helpProvider1.SetShowHelp(this, true);
            Text = "TF Util (Beta V1.3)";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private SplitContainer splitContainer1;
        private RichTextBox richTextBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private RadioButton exportLocalwkstRadio;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private RadioButton localwkstRadio;
        private Button transferirBtn;
        private Label label2;
        private CheckBox interpolarChk;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarComoToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem manualDoUsuárioToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Panel panel2;
        private SplitContainer splitContainer2;
        private Panel panel3;
        private CheckBox guardarCaminhosChk;
        private Button tfBtn;
        private RadioButton exportWorkspaceRadio;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem preferênciasToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Panel panel4;
        private Button killtfBtn;
        private Button workspaceBtn;
        private Button localwkstBtn;
        private Button logBtn;
        private Label label3;
        private HelpProvider helpProvider1;
    }
}