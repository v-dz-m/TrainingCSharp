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
    /// <summary>
    /// Данная форма отображает файлы, доступные для данного урока.
    /// </summary>
    public partial class LessonForm : Form
    {
        public LessonForm()
        {
            InitializeComponent();
        }

        internal string nameOfLesson;
        internal string pathOfLesson;
        private List<string> files = new List<string>();

        /// <summary>
        /// Данная процедура служит для заполнения таблицы lessonGrid.
        /// </summary>
        /// <param name="path"></param>
        private void FillLessonGrid(string path)
        {
            files.Clear();
            files.AddRange(Directory.EnumerateDirectories(path));
            files.AddRange(Directory.EnumerateFiles(path));
            lessonGrid.Rows.Clear();
            foreach (var fElement in files)
            {
                lessonGrid.Rows.Add();
                switch (Path.GetExtension(fElement))
                {
                    case ".docx":
                    case ".doc":
                        lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[0].Value = new Bitmap(Курсовая_1._00.Properties.Resources.ww);
                        break;
                    case ".pptx":
                    case ".ppt":
                        lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[0].Value = new Bitmap(Курсовая_1._00.Properties.Resources.pp);
                        break;
                    case ".xlsx":
                    case ".xls":
                        lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[0].Value = new Bitmap(Курсовая_1._00.Properties.Resources.xx);
                        break;
                    case ".jpg":
                    case ".png":
                    case ".bmp":
                    case ".gif":
                        lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[0].Value = new Bitmap(Курсовая_1._00.Properties.Resources.ii);
                        break;
                    case ".avi":
                    case ".mp4":
                    case ".mkv":
                        lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[0].Value = new Bitmap(Курсовая_1._00.Properties.Resources.mv);
                        break;
                    case ".mp3":
                        lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[0].Value = new Bitmap(Курсовая_1._00.Properties.Resources.mp);
                        break;
                    case ".exe":
                        lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[0].Value = new Bitmap(Курсовая_1._00.Properties.Resources.ee);
                        break;
                    case ".pdf":
                        lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[0].Value = new Bitmap(Курсовая_1._00.Properties.Resources.pf);
                        break;
                    case ".xml":
                        lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[0].Value = new Bitmap(Курсовая_1._00.Properties.Resources.xm);
                        break;
                    case "":
                        lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[0].Value = new Bitmap(Курсовая_1._00.Properties.Resources.fd);
                        break;
                    default:
                        lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[0].Value = new Bitmap(Курсовая_1._00.Properties.Resources.ff);
                        break;
                }
                lessonGrid.Rows[lessonGrid.RowCount - 1].Cells[1].Value = Path.GetFileName(fElement);
            }
        }

        private void LessonForm_Load(object sender, EventArgs e)
        {
            Text = nameOfLesson;
            FillLessonGrid(pathOfLesson);
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void завершитьУрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LessonForm.ActiveForm.Close();
        }

        private void lessonGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1)
            {
                return;
            }
            //В ответ на выбор определенного файла происходит ответное действие.
            try
            {
                //Если папка с названием "презентация" - открыть содержимое в форме SlideForm.
                if (Path.GetExtension(files[e.RowIndex]) == "" && Path.GetFileName(files[e.RowIndex]) == "презентация")
                {
                    SlideForm slideForm = new SlideForm()
                    {
                        slideFormPath = files[e.RowIndex]
                    };

                    slideForm.FormBorderStyle = FormBorderStyle.None;
                    slideForm.TopMost = true;
                    slideForm.Bounds = Screen.PrimaryScreen.Bounds;

                    slideForm.Show();
                }
                else
                {
                    //Если xml-файл с название "тест.xml" - открыть содержимое в форме TestForm.
                    if (Path.GetExtension(files[e.RowIndex]) == ".xml" && Path.GetFileName(files[e.RowIndex]) == "тест.xml")
                    {
                        TestForm testForm = new TestForm()
                        {
                            path = files[e.RowIndex],
                            name = nameOfLesson
                        };
                        testForm.Show();
                    }
                    else
                    {
                        //Иначе - открытие файла (в Проводнике, на исполнение или в сторонней программе.
                        Process.Start(files[e.RowIndex]);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Произошла ошибка");
            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillLessonGrid(pathOfLesson);
        }
    }
}
