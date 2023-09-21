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
            groupBox1 = new GroupBox();
            importBooksRadio = new RadioButton();
            localwkstRadio = new RadioButton();
            exportWorkspaceRadio = new RadioButton();
            exportLocalwkstRadio = new RadioButton();
            groupBox2 = new GroupBox();
            guardarCaminhosChk = new CheckBox();
            interpolarChk = new CheckBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            killtfBtn = new Button();
            localwkstBtn = new Button();
            logBtn = new Button();
            workspaceBtn = new Button();
            splitContainer2 = new SplitContainer();
            transferirBtn = new Button();
            tfBtn = new Button();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
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
            splitContainer1.Size = new Size(1237, 576);
            splitContainer1.SplitterDistance = 918;
            splitContainer1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.AllowDrop = true;
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(914, 572);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(splitContainer2, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 157F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.Size = new Size(311, 572);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(importBooksRadio);
            groupBox1.Controls.Add(localwkstRadio);
            groupBox1.Controls.Add(exportWorkspaceRadio);
            groupBox1.Controls.Add(exportLocalwkstRadio);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 185);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Destino";
            // 
            // importBooksRadio
            // 
            importBooksRadio.AutoSize = true;
            importBooksRadio.Location = new Point(14, 135);
            importBooksRadio.Name = "importBooksRadio";
            importBooksRadio.Size = new Size(262, 29);
            importBooksRadio.TabIndex = 12;
            importBooksRadio.Text = "Importar books (ARQ_PCCF)";
            importBooksRadio.UseVisualStyleBackColor = true;
            importBooksRadio.Click += importBooksRadio_Click;
            // 
            // localwkstRadio
            // 
            localwkstRadio.AutoSize = true;
            localwkstRadio.Checked = true;
            localwkstRadio.Location = new Point(14, 30);
            localwkstRadio.Name = "localwkstRadio";
            localwkstRadio.Size = new Size(245, 29);
            localwkstRadio.TabIndex = 10;
            localwkstRadio.TabStop = true;
            localwkstRadio.Text = "Bradesco Client (localwkst)";
            localwkstRadio.UseVisualStyleBackColor = true;
            localwkstRadio.Click += localwkstRadio_Click;
            // 
            // exportWorkspaceRadio
            // 
            exportWorkspaceRadio.AutoSize = true;
            exportWorkspaceRadio.Location = new Point(14, 100);
            exportWorkspaceRadio.Name = "exportWorkspaceRadio";
            exportWorkspaceRadio.Size = new Size(192, 29);
            exportWorkspaceRadio.TabIndex = 11;
            exportWorkspaceRadio.Text = "Exportar workspace";
            exportWorkspaceRadio.UseVisualStyleBackColor = true;
            exportWorkspaceRadio.Click += exportWorkspaceRadio_Click;
            // 
            // exportLocalwkstRadio
            // 
            exportLocalwkstRadio.AutoSize = true;
            exportLocalwkstRadio.Location = new Point(14, 65);
            exportLocalwkstRadio.Name = "exportLocalwkstRadio";
            exportLocalwkstRadio.Size = new Size(180, 29);
            exportLocalwkstRadio.TabIndex = 8;
            exportLocalwkstRadio.Text = "Exportar localwkst";
            exportLocalwkstRadio.UseVisualStyleBackColor = true;
            exportLocalwkstRadio.Click += exportLocalwkstRadio_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(guardarCaminhosChk);
            groupBox2.Controls.Add(interpolarChk);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(5, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 106);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opções";
            // 
            // guardarCaminhosChk
            // 
            guardarCaminhosChk.AutoSize = true;
            guardarCaminhosChk.Checked = true;
            guardarCaminhosChk.CheckState = CheckState.Checked;
            guardarCaminhosChk.Location = new Point(14, 65);
            guardarCaminhosChk.Name = "guardarCaminhosChk";
            guardarCaminhosChk.Size = new Size(182, 29);
            guardarCaminhosChk.TabIndex = 15;
            guardarCaminhosChk.Text = "Guardar caminhos";
            guardarCaminhosChk.UseVisualStyleBackColor = true;
            // 
            // interpolarChk
            // 
            interpolarChk.AutoSize = true;
            interpolarChk.Checked = true;
            interpolarChk.CheckState = CheckState.Checked;
            interpolarChk.Location = new Point(14, 30);
            interpolarChk.Name = "interpolarChk";
            interpolarChk.Size = new Size(197, 29);
            interpolarChk.TabIndex = 14;
            interpolarChk.Text = "Interpolar saída java";
            interpolarChk.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(5, 312);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(301, 151);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Atalhos";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel2.Controls.Add(killtfBtn, 3, 2);
            tableLayoutPanel2.Controls.Add(localwkstBtn, 1, 0);
            tableLayoutPanel2.Controls.Add(logBtn, 1, 2);
            tableLayoutPanel2.Controls.Add(workspaceBtn, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 27);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(295, 121);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // killtfBtn
            // 
            killtfBtn.Cursor = Cursors.Hand;
            killtfBtn.Dock = DockStyle.Fill;
            killtfBtn.Location = new Point(154, 67);
            killtfBtn.Name = "killtfBtn";
            killtfBtn.Size = new Size(112, 51);
            killtfBtn.TabIndex = 20;
            killtfBtn.Text = "kill TF";
            killtfBtn.UseVisualStyleBackColor = true;
            killtfBtn.Click += killtfBtn_Click;
            // 
            // localwkstBtn
            // 
            localwkstBtn.Cursor = Cursors.Hand;
            localwkstBtn.Dock = DockStyle.Fill;
            localwkstBtn.Location = new Point(26, 3);
            localwkstBtn.Name = "localwkstBtn";
            localwkstBtn.Size = new Size(112, 50);
            localwkstBtn.TabIndex = 18;
            localwkstBtn.Text = "localwkst";
            localwkstBtn.UseVisualStyleBackColor = true;
            localwkstBtn.Click += localwkstBtn_Click;
            // 
            // logBtn
            // 
            logBtn.Cursor = Cursors.Hand;
            logBtn.Dock = DockStyle.Fill;
            logBtn.Location = new Point(26, 67);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(112, 51);
            logBtn.TabIndex = 17;
            logBtn.Text = "log";
            logBtn.UseVisualStyleBackColor = true;
            logBtn.Click += logBtn_Click;
            // 
            // workspaceBtn
            // 
            workspaceBtn.Cursor = Cursors.Hand;
            workspaceBtn.Dock = DockStyle.Fill;
            workspaceBtn.Location = new Point(154, 3);
            workspaceBtn.Name = "workspaceBtn";
            workspaceBtn.Size = new Size(112, 50);
            workspaceBtn.TabIndex = 19;
            workspaceBtn.Text = "workspace";
            workspaceBtn.UseVisualStyleBackColor = true;
            workspaceBtn.Click += workspaceBtn_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel2;
            splitContainer2.Location = new Point(5, 500);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(transferirBtn);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tfBtn);
            splitContainer2.Panel2MinSize = 60;
            splitContainer2.Size = new Size(301, 67);
            splitContainer2.SplitterDistance = 211;
            splitContainer2.TabIndex = 11;
            // 
            // transferirBtn
            // 
            transferirBtn.Cursor = Cursors.Hand;
            transferirBtn.Dock = DockStyle.Fill;
            transferirBtn.Location = new Point(0, 0);
            transferirBtn.Name = "transferirBtn";
            transferirBtn.Size = new Size(211, 67);
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
            tfBtn.Dock = DockStyle.Right;
            tfBtn.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            tfBtn.ForeColor = Color.White;
            tfBtn.Location = new Point(0, 0);
            tfBtn.Name = "tfBtn";
            tfBtn.Size = new Size(86, 67);
            tfBtn.TabIndex = 0;
            tfBtn.Text = "TF";
            tfBtn.UseVisualStyleBackColor = true;
            tfBtn.Click += tfBtn_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripDropDownButton2, toolStripDropDownButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1237, 34);
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
            panel2.Size = new Size(1237, 576);
            panel2.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "assets\\manual.html";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 610);
            Controls.Add(panel2);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            helpProvider1.SetShowHelp(this, true);
            Text = "TF Util (Beta V1.5)";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
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
        private RadioButton exportLocalwkstRadio;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton localwkstRadio;
        private Button transferirBtn;
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
        private CheckBox guardarCaminhosChk;
        private Button tfBtn;
        private RadioButton exportWorkspaceRadio;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem preferênciasToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button killtfBtn;
        private Button workspaceBtn;
        private Button localwkstBtn;
        private Button logBtn;
        private HelpProvider helpProvider1;
        private RadioButton importBooksRadio;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel2;
    }
}