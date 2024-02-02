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
using System.Xml.Serialization;

namespace Курсовая_1._00
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<string> folders = new List<string>();          //список, содержащий пути к папкам корневого каталога
        string rootDirectoryPath;                           //путь к корневому каталогу

        SerializedInfo saveInfo = new SerializedInfo();
        XmlSerializer serializer = new XmlSerializer(typeof(SerializedInfo));
        /// <summary>
        /// Данная процедура служит для заполнения таблицы folderGrid.
        /// </summary>
        /// <param name="pathes"></param>
        private void FillFolderGrid(string path)
        {
            folders.Clear();
            folders.AddRange(Directory.EnumerateDirectories(path));
            folderGrid.Rows.Clear();
            foreach (var pElement in folders)
            {
                folderGrid.Rows.Add();
                folderGrid.Rows[folderGrid.RowCount - 1].Cells[0].Value = Path.GetFileName(pElement);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            try
            {
                //Десериализация параметров из файла SaveInfo.xml.
                using (FileStream fs = new FileStream("SaveInfo.xml", FileMode.Open))
                {
                    saveInfo = (SerializedInfo)serializer.Deserialize(fs);
                }
                rootDirectoryPath = saveInfo.rootPath;
            }
            catch (Exception)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    rootDirectoryPath = folderBrowserDialog1.SelectedPath;
                    saveInfo.rootPath = rootDirectoryPath;
                }
                else
                {
                    rootDirectoryPath = Application.StartupPath;
                    saveInfo.rootPath = rootDirectoryPath;
                }
            }

            FillFolderGrid(rootDirectoryPath);
        }

        private void расположениеУроковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(rootDirectoryPath);
        }

        private void сменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                rootDirectoryPath = folderBrowserDialog1.SelectedPath;
                FillFolderGrid(rootDirectoryPath);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveInfo.rootPath = rootDirectoryPath;

            //Сериализация параметров в файл SaveInfo.xml.
            using (FileStream fs = new FileStream("SaveInfo.xml", FileMode.Create))
            {
                serializer.Serialize(fs, saveInfo);
            }
        }

        private void folderGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                UnitForm unitForm = new UnitForm()
                {
                    nameOfUnit = Path.GetFileNameWithoutExtension(folders[e.RowIndex]),
                    pathOfUnit = folders[e.RowIndex] 
                };
                unitForm.Show();
            }
        }

        private void дополнительнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Vadim Ganchuk" + Environment.NewLine + "Special for BSUIR Affiliate Minsk Radioengineering College", "Tutorial C# 1.00");
        }

        private void обновитьStripMenuItem_Click(object sender, EventArgs e)
        {
            FillFolderGrid(rootDirectoryPath);
        }
    }

    /// <summary>
    /// Класс для сериализации в файл "SaveInfo.xml".
    /// </summary>
    [Serializable]
    public class SerializedInfo
    {
        public string rootPath { get; set; }
    }
}
