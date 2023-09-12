namespace TFUtil
{
    partial class PreferenciasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            button2 = new Button();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            button3 = new Button();
            tabPage2 = new TabPage();
            folderBrowserDialog1 = new FolderBrowserDialog();
            helpProvider1 = new HelpProvider();
            splitContainer1 = new SplitContainer();
            button5 = new Button();
            button4 = new Button();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(647, 431);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(639, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Diretórios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(633, 387);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 122);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Diretório do CLIENT";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "C:\\CLIENT";
            // 
            // button1
            // 
            button1.Location = new Point(512, 50);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 3;
            button1.Text = "Alterar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(button2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(627, 122);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Diretório do Workspace";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(479, 31);
            textBox2.TabIndex = 1;
            textBox2.Text = "C:\\workspaceFDDB";
            // 
            // button2
            // 
            button2.Location = new Point(512, 50);
            button2.Name = "button2";
            button2.Size = new Size(94, 31);
            button2.TabIndex = 3;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(button3);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 259);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(627, 125);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Editor de texto (externo)";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(479, 31);
            textBox3.TabIndex = 1;
            textBox3.Text = "C:\\Windows\\notepad.exe";
            // 
            // button3
            // 
            button3.Location = new Point(512, 50);
            button3.Name = "button3";
            button3.Size = new Size(94, 31);
            button3.TabIndex = 3;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(639, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editor de Texto";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Size = new Size(647, 484);
            splitContainer1.SplitterDistance = 431;
            splitContainer1.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(523, 8);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 1;
            button5.Text = "Salvar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(393, 8);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 0;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // PreferenciasForm
            // 
            AcceptButton = button5;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button4;
            ClientSize = new Size(647, 484);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PreferenciasForm";
            ShowIcon = false;
            Text = "Preferências";
            Load += PreferenciasForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button button1;
        private HelpProvider helpProvider1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Button button2;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private Button button3;
        private SplitContainer splitContainer1;
        private Button button5;
        private Button button4;
        private OpenFileDialog openFileDialog1;
    }
}