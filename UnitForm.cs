using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_1._00
{
    public partial class UnitForm : Form
    {
        public UnitForm()
        {
            InitializeComponent();
        }

        internal string nameOfUnit;
        internal string pathOfUnit;
        private List<string> lessonsOfUnit = new List<string>();

        private void FillUnitGrid(string path)
        {
            lessonsOfUnit.Clear();
            lessonsOfUnit.AddRange(Directory.EnumerateDirectories(path));
            unitGrid.Rows.Clear();
            foreach (var uElement in lessonsOfUnit)
            {
                unitGrid.Rows.Add();
                unitGrid.Rows[unitGrid.RowCount - 1].Cells[0].Value = Path.GetFileName(uElement);
            }
        }

        private void UnitForm_Load(object sender, EventArgs e)
        {
            Text = nameOfUnit;
            FillUnitGrid(pathOfUnit);
        }

        private void unitGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                LessonForm lessonForm = new LessonForm()
                {
                    nameOfLesson = Path.GetFileName(lessonsOfUnit[e.RowIndex]),
                    pathOfLesson = lessonsOfUnit[e.RowIndex]
                };
                lessonForm.Show();
            }
        }

        private void вернутьсяВНачальноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void открытьРазделВПроводникеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(pathOfUnit);
        }

        private void обновитьStripMenuItem_Click(object sender, EventArgs e)
        {
            FillUnitGrid(pathOfUnit);
        }
    }
}
