namespace Курсовая_1._00
{
    partial class UnitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьРазделВПроводникеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кОглавлениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitGrid = new System.Windows.Forms.DataGridView();
            this.FileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.открытьРазделВПроводникеToolStripMenuItem,
            this.кОглавлениюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("обновитьToolStripMenuItem.Image")));
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(28, 24);
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьStripMenuItem_Click);
            // 
            // открытьРазделВПроводникеToolStripMenuItem
            // 
            this.открытьРазделВПроводникеToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.открытьРазделВПроводникеToolStripMenuItem.Name = "открытьРазделВПроводникеToolStripMenuItem";
            this.открытьРазделВПроводникеToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.открытьРазделВПроводникеToolStripMenuItem.Text = "Открыть раздел в проводнике";
            this.открытьРазделВПроводникеToolStripMenuItem.Click += new System.EventHandler(this.открытьРазделВПроводникеToolStripMenuItem_Click);
            // 
            // кОглавлениюToolStripMenuItem
            // 
            this.кОглавлениюToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.кОглавлениюToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.кОглавлениюToolStripMenuItem.Name = "кОглавлениюToolStripMenuItem";
            this.кОглавлениюToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.кОглавлениюToolStripMenuItem.Text = "К оглавлению";
            this.кОглавлениюToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяВНачальноеОкноToolStripMenuItem_Click);
            // 
            // unitGrid
            // 
            this.unitGrid.AllowUserToAddRows = false;
            this.unitGrid.AllowUserToDeleteRows = false;
            this.unitGrid.AllowUserToResizeColumns = false;
            this.unitGrid.AllowUserToResizeRows = false;
            this.unitGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.unitGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unitGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.unitGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitGrid.ColumnHeadersVisible = false;
            this.unitGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileNameColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.unitGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.unitGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.unitGrid.Location = new System.Drawing.Point(0, 28);
            this.unitGrid.Name = "unitGrid";
            this.unitGrid.RowHeadersVisible = false;
            this.unitGrid.RowHeadersWidth = 50;
            this.unitGrid.RowTemplate.Height = 42;
            this.unitGrid.Size = new System.Drawing.Size(559, 421);
            this.unitGrid.TabIndex = 4;
            this.unitGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.unitGrid_CellDoubleClick);
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.FileNameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.FileNameColumn.FillWeight = 241.766F;
            this.FileNameColumn.HeaderText = "";
            this.FileNameColumn.Name = "FileNameColumn";
            this.FileNameColumn.ReadOnly = true;
            // 
            // UnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 449);
            this.ControlBox = false;
            this.Controls.Add(this.unitGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UnitForm";
            this.Text = "UnitForm";
            this.Load += new System.EventHandler(this.UnitForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem кОглавлениюToolStripMenuItem;
        private System.Windows.Forms.DataGridView unitGrid;
        private System.Windows.Forms.ToolStripMenuItem открытьРазделВПроводникеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;
    }
}