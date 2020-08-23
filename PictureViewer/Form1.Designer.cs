namespace PictureViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilesList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SlideShowStop = new System.Windows.Forms.Button();
            this.SlideShowReset = new System.Windows.Forms.Button();
            this.SlideShowStart = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.Backword = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ViewBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenItem,
            this.CloseItem,
            this.ExitItem});
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.folderToolStripMenuItem.Text = "&Folder";
            // 
            // OpenItem
            // 
            this.OpenItem.Name = "OpenItem";
            this.OpenItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenItem.Size = new System.Drawing.Size(146, 22);
            this.OpenItem.Text = "&Open";
            this.OpenItem.Click += new System.EventHandler(this.OpenItem_Click);
            // 
            // CloseItem
            // 
            this.CloseItem.Name = "CloseItem";
            this.CloseItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CloseItem.Size = new System.Drawing.Size(146, 22);
            this.CloseItem.Text = "&Close";
            this.CloseItem.Click += new System.EventHandler(this.CloseItem_Click);
            // 
            // ExitItem
            // 
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExitItem.Size = new System.Drawing.Size(146, 22);
            this.ExitItem.Text = "&Exit";
            this.ExitItem.Click += new System.EventHandler(this.ExitItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramItem,
            this.AuthorItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // ProgramItem
            // 
            this.ProgramItem.Name = "ProgramItem";
            this.ProgramItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ProgramItem.Size = new System.Drawing.Size(161, 22);
            this.ProgramItem.Text = "&Program";
            // 
            // AuthorItem
            // 
            this.AuthorItem.Name = "AuthorItem";
            this.AuthorItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AuthorItem.Size = new System.Drawing.Size(161, 22);
            this.AuthorItem.Text = "&Author";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // FilesList
            // 
            this.FilesList.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilesList.FormattingEnabled = true;
            this.FilesList.ItemHeight = 15;
            this.FilesList.Location = new System.Drawing.Point(0, 24);
            this.FilesList.Name = "FilesList";
            this.FilesList.ScrollAlwaysVisible = true;
            this.FilesList.Size = new System.Drawing.Size(207, 571);
            this.FilesList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.SlideShowStop);
            this.groupBox1.Controls.Add(this.SlideShowReset);
            this.groupBox1.Controls.Add(this.SlideShowStart);
            this.groupBox1.Controls.Add(this.Forward);
            this.groupBox1.Controls.Add(this.Backword);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(207, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Керування";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "0 %";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(437, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 24);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(547, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // SlideShowStop
            // 
            this.SlideShowStop.Location = new System.Drawing.Point(153, 70);
            this.SlideShowStop.Name = "SlideShowStop";
            this.SlideShowStop.Size = new System.Drawing.Size(114, 24);
            this.SlideShowStop.TabIndex = 4;
            this.SlideShowStop.Text = "Стоп";
            this.SlideShowStop.UseVisualStyleBackColor = true;
            // 
            // SlideShowReset
            // 
            this.SlideShowReset.Location = new System.Drawing.Point(153, 45);
            this.SlideShowReset.Name = "SlideShowReset";
            this.SlideShowReset.Size = new System.Drawing.Size(114, 24);
            this.SlideShowReset.TabIndex = 3;
            this.SlideShowReset.Text = "Зброс";
            this.SlideShowReset.UseVisualStyleBackColor = true;
            // 
            // SlideShowStart
            // 
            this.SlideShowStart.Location = new System.Drawing.Point(153, 20);
            this.SlideShowStart.Name = "SlideShowStart";
            this.SlideShowStart.Size = new System.Drawing.Size(114, 24);
            this.SlideShowStart.TabIndex = 2;
            this.SlideShowStart.Text = "Старт";
            this.SlideShowStart.UseVisualStyleBackColor = true;
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(294, 37);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(111, 31);
            this.Forward.TabIndex = 1;
            this.Forward.Text = ">>>";
            this.Forward.UseVisualStyleBackColor = true;
            // 
            // Backword
            // 
            this.Backword.Location = new System.Drawing.Point(16, 37);
            this.Backword.Name = "Backword";
            this.Backword.Size = new System.Drawing.Size(111, 31);
            this.Backword.TabIndex = 0;
            this.Backword.Text = "<<<";
            this.Backword.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ViewBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(207, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 471);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перегляд";
            // 
            // ViewBox1
            // 
            this.ViewBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewBox1.Image = global::PictureViewer.Properties.Resources.iconfinder_365_Vlc_logo_4375163;
            this.ViewBox1.Location = new System.Drawing.Point(3, 17);
            this.ViewBox1.Name = "ViewBox1";
            this.ViewBox1.Size = new System.Drawing.Size(816, 451);
            this.ViewBox1.TabIndex = 4;
            this.ViewBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FilesList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переглядач зображень";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenItem;
        private System.Windows.Forms.ToolStripMenuItem CloseItem;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListBox FilesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ViewBox1;
        private System.Windows.Forms.Button Backword;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button SlideShowStart;
        private System.Windows.Forms.Button SlideShowReset;
        private System.Windows.Forms.Button SlideShowStop;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

