namespace ExamOutlineFilter
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            loadOutlineToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            txtOutline = new TextBox();
            listOverRange = new ListBox();
            txtArticle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            openArticle = new OpenFileDialog();
            openOutline = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(997, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(137, 26);
            openToolStripMenuItem.Text = "&Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(137, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadOutlineToolStripMenuItem, runToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // loadOutlineToolStripMenuItem
            // 
            loadOutlineToolStripMenuItem.Name = "loadOutlineToolStripMenuItem";
            loadOutlineToolStripMenuItem.Size = new Size(186, 26);
            loadOutlineToolStripMenuItem.Text = "Load Outline...";
            loadOutlineToolStripMenuItem.Click += loadOutlineToolStripMenuItem_Click;
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(186, 26);
            runToolStripMenuItem.Text = "&Run";
            runToolStripMenuItem.Click += runToolStripMenuItem_Click;
            // 
            // txtOutline
            // 
            txtOutline.Location = new Point(0, 68);
            txtOutline.Multiline = true;
            txtOutline.Name = "txtOutline";
            txtOutline.Size = new Size(472, 325);
            txtOutline.TabIndex = 1;
            // 
            // listOverRange
            // 
            listOverRange.FormattingEnabled = true;
            listOverRange.Location = new Point(0, 419);
            listOverRange.Name = "listOverRange";
            listOverRange.Size = new Size(948, 184);
            listOverRange.TabIndex = 2;
            // 
            // txtArticle
            // 
            txtArticle.Location = new Point(501, 68);
            txtArticle.Multiline = true;
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(447, 325);
            txtArticle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 43);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 4;
            label1.Text = "考纲";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 43);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "文章";
            // 
            // openArticle
            // 
            openArticle.FileName = "Article.txt";
            openArticle.Filter = "Text files|*.txt|All files|*.*";
            // 
            // openOutline
            // 
            openOutline.FileName = "Outline.txt";
            openOutline.Filter = "Text files|*.txt|All files|*.*";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 610);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtArticle);
            Controls.Add(listOverRange);
            Controls.Add(txtOutline);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private TextBox txtOutline;
        private ListBox listOverRange;
        private TextBox txtArticle;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem runToolStripMenuItem;
        private OpenFileDialog openArticle;
        private ToolStripMenuItem loadOutlineToolStripMenuItem;
        private OpenFileDialog openOutline;
    }
}
