using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_1._00
{
    public partial class SlideForm : Form
    {
        public SlideForm()
        {
            InitializeComponent();
        }

        List<string> slides = new List<string>();   // список слайдов
        int runningSlide;                           // текущий слайд
        int countOfSlides;                          // количество слайдов
        
        internal string slideFormPath;              // расположение папки со слайдами

        private void SlideForm_Load(object sender, EventArgs e)
        {
            slides.AddRange(Directory.EnumerateFiles(slideFormPath, "*.png"));
            if (slides.Count == 0)
            {
                MessageBox.Show("В выбранной папке слайды не обнаружены", "Произошла ошибка");
                this.Close();
                return;
            }
            countOfSlides = slides.Count;
            textBox2.Text = countOfSlides.ToString();
            runningSlide = 0;
            ShowSlide(runningSlide);
        }

        private void ShowSlide(int slide)
        {
            pictureBox1.Image = Bitmap.FromFile(slides[runningSlide]);
            textBox1.Text = (runningSlide + 1).ToString();
            if (slide == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            if (slide < countOfSlides - 1 && countOfSlides > 1)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runningSlide--;
            ShowSlide(runningSlide);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            runningSlide++;
            ShowSlide(runningSlide);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int currentSlide = runningSlide;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    runningSlide = Convert.ToByte(textBox1.Text) - 1;
                    ShowSlide(runningSlide);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Описание ошибки" + Environment.NewLine + exception.Message, "Произошла ошибка");
                    runningSlide = currentSlide;
                    textBox1.Text = (runningSlide + 1).ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
