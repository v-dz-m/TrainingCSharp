namespace Курсовая_1._00
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderGrid = new System.Windows.Forms.DataGridView();
            this.FileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корневойКаталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расположениеУроковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.folderGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderGrid
            // 
            this.folderGrid.AllowUserToAddRows = false;
            this.folderGrid.AllowUserToDeleteRows = false;
            this.folderGrid.AllowUserToResizeColumns = false;
            this.folderGrid.AllowUserToResizeRows = false;
            this.folderGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.folderGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.folderGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.folderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.folderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.folderGrid.ColumnHeadersVisible = false;
            this.folderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileNameColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.folderGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.folderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.folderGrid.Location = new System.Drawing.Point(0, 28);
            this.folderGrid.Name = "folderGrid";
            this.folderGrid.RowHeadersVisible = false;
            this.folderGrid.RowHeadersWidth = 50;
            this.folderGrid.RowTemplate.Height = 42;
            this.folderGrid.Size = new System.Drawing.Size(536, 430);
            this.folderGrid.TabIndex = 3;
            this.folderGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.folderGrid_CellMouseDoubleClick);
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FileNameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.FileNameColumn.FillWeight = 241.766F;
            this.FileNameColumn.HeaderText = "";
            this.FileNameColumn.Name = "FileNameColumn";
            this.FileNameColumn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.корневойКаталогToolStripMenuItem,
            this.дополнительнаяИнформацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("обновитьToolStripMenuItem.Image")));
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(28, 24);
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьStripMenuItem_Click);
            // 
            // корневойКаталогToolStripMenuItem
            // 
            this.корневойКаталогToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расположениеУроковToolStripMenuItem,
            this.сменитьToolStripMenuItem});
            this.корневойКаталогToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.корневойКаталогToolStripMenuItem.Name = "корневойКаталогToolStripMenuItem";
            this.корневойКаталогToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.корневойКаталогToolStripMenuItem.Text = "Корневой каталог";
            // 
            // расположениеУроковToolStripMenuItem
            // 
            this.расположениеУроковToolStripMenuItem.Name = "расположениеУроковToolStripMenuItem";
            this.расположениеУроковToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.расположениеУроковToolStripMenuItem.Text = "Расположение уроков";
            this.расположениеУроковToolStripMenuItem.Click += new System.EventHandler(this.расположениеУроковToolStripMenuItem_Click);
            // 
            // сменитьToolStripMenuItem
            // 
            this.сменитьToolStripMenuItem.Name = "сменитьToolStripMenuItem";
            this.сменитьToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.сменитьToolStripMenuItem.Text = "Сменить корневой каталог";
            this.сменитьToolStripMenuItem.Click += new System.EventHandler(this.сменитьToolStripMenuItem_Click);
            // 
            // дополнительнаяИнформацияToolStripMenuItem
            // 
            this.дополнительнаяИнформацияToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.дополнительнаяИнформацияToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.дополнительнаяИнформацияToolStripMenuItem.Name = "дополнительнаяИнформацияToolStripMenuItem";
            this.дополнительнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.дополнительнаяИнформацияToolStripMenuItem.Text = "О программе";
            this.дополнительнаяИнформацияToolStripMenuItem.Click += new System.EventHandler(this.дополнительнаяИнформацияToolStripMenuItem_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(536, 458);
            this.Controls.Add(this.folderGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать в обучающую программу!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.folderGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView folderGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem корневойКаталогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem расположениеУроковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;

    }
}

