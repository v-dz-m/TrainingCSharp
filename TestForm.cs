using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Курсовая_1._00
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        /// <summary>Название теста</summary>
        internal string name;
        /// <summary>Местоположение теста</summary>
        internal string path;

        DateTime timeOfBegin;
        DateTime timeOfEnd;

        /// <summary>Список всех вопросов из файла</summary>
        List<TestQuestion> listOfQuestions = new List<TestQuestion>();
        /// <summary>Сгенерированный список вопросов для данного теста</summary>
        List<TestQuestion> thisTest = new List<TestQuestion>();
        /// <summary>Формируемый отчет о прохождении вопросов теста</summary>
        StringBuilder report = new StringBuilder();

        XmlSerializer serializer = new XmlSerializer(typeof(Test));
        public Test test = new Test();

        bool[] usingOfQuestions;            //специальный массив, чтобы сгенерированные вопросы не повторялись
        int currentQuestion = 1;            //текущий вопрос, который проходит пользователь
        int countOfCorrectAnswers = 0;      //количество правильно отвеченных пользователем вопросов
        int countOfQuestions = 10;          //количество вопросов, которые проходит пользователь

        private void TestForm_Load(object sender, EventArgs e)
        {
            Text = name;
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    test = (Test)serializer.Deserialize(fs);
                }
            }
            catch (Exception expection)
            {
                MessageBox.Show(expection.Message, "Ошибка");
            }

            //Если количество вопросов в файле меньше, чем по умолчанию (10 вопросов).
            if (test.Questions.Count < countOfQuestions)
            {
                countOfQuestions = test.Questions.Count;
            }

            Random random = new Random(DateTime.Now.Millisecond);
            usingOfQuestions = new bool[test.Questions.Count];

            for (int i = 0; i < countOfQuestions; i++)
            {
                thisTest.Add(test.Questions[GenerateNumber(random, test.Questions.Count)]);
            }

            timeOfBegin = DateTime.Now;
            FillQuestionForm(thisTest[0]);
        }

        /// <summary>
        /// Функция генерирует номер вопроса случайным образом без повторений.
        /// </summary>
        /// <param name="random"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private int GenerateNumber(Random random, int count)
        {
            int answer = random.Next(0, count);
            if (usingOfQuestions[answer] == true)
            {
                return GenerateNumber(random, count);
            }
            usingOfQuestions[answer] = true;
            return answer;
        }

        /// <summary>
        /// Процедура для заполнения формы с вопросом.
        /// </summary>
        /// <param name="testQuestion"></param>
        private void FillQuestionForm(TestQuestion testQuestion)
        {
            label1.Text = testQuestion.question;
            radioButton1.Text = testQuestion.textOfFirstVariant;
            radioButton2.Text = testQuestion.textOfSecondVariant;
            radioButton3.Text = testQuestion.textOfThirdVariant;
            radioButton4.Text = testQuestion.textOfFourthVariant;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userAnswer = 0;

            //Извлечение выбранного пользователем варианта ответа.
            if (radioButton1.Checked)
            {
                userAnswer = 1;
            }
            if (radioButton2.Checked)
            {
                userAnswer = 2;
            }
            if (radioButton3.Checked)
            {
                userAnswer = 3;
            }
            if (radioButton4.Checked)
            {
                userAnswer = 4;
            }

            //Если пользователь не выбрал ни один из вариантов ответа.
            if (userAnswer == 0)
            {
                MessageBox.Show("Выберите один из вариантов!", "Ошибка");
                return;
            }
            //Если пользователь выбрал правильный вариант ответа.
            if (userAnswer == thisTest[currentQuestion - 1].answer)
            {
                countOfCorrectAnswers++;
            }

            report.Append("Вопрос №" + currentQuestion + ": " + thisTest[currentQuestion - 1].question + Environment.NewLine);
            report.Append("Выбранный пользователем вариант ответа: ");
            switch (userAnswer)
            {
                case 1:
                    report.Append(thisTest[currentQuestion - 1].textOfFirstVariant + Environment.NewLine);
                    break;
                case 2:
                    report.Append(thisTest[currentQuestion - 1].textOfSecondVariant + Environment.NewLine);
                    break;
                case 3:
                    report.Append(thisTest[currentQuestion - 1].textOfThirdVariant + Environment.NewLine);
                    break;
                case 4:
                    report.Append(thisTest[currentQuestion - 1].textOfFourthVariant + Environment.NewLine);
                    break;
            }
            report.Append("Правильный вариант ответа: ");
            switch (thisTest[currentQuestion - 1].answer)
            {
                case 1:
                    report.Append(thisTest[currentQuestion - 1].textOfFirstVariant + Environment.NewLine);
                    break;
                case 2:
                    report.Append(thisTest[currentQuestion - 1].textOfSecondVariant + Environment.NewLine);
                    break;
                case 3:
                    report.Append(thisTest[currentQuestion - 1].textOfThirdVariant + Environment.NewLine);
                    break;
                case 4:
                    report.Append(thisTest[currentQuestion - 1].textOfFourthVariant + Environment.NewLine);
                    break; 
            }
            if (userAnswer == thisTest[currentQuestion - 1].answer)
            {
                report.Append("Ответ верный" + Environment.NewLine + "----------" + Environment.NewLine);
            }
            else
            {
                report.Append("Ответ неверный" + Environment.NewLine + "----------" + Environment.NewLine);
            }

            //Если был пройден предпоследний вопрос.
            if (currentQuestion + 1 == countOfQuestions)
            {
                button1.Text = "Завершить";
            }

            //Если был пройден последний вопрос.
            if (currentQuestion == countOfQuestions)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    timeOfEnd = DateTime.Now;
                    report.Append("Время начала тестирования - " + timeOfBegin.ToString() + Environment.NewLine);
                    report.Append("Время завершения тестирования - " + timeOfEnd.ToString());
                    using (StreamWriter file = new StreamWriter(saveFileDialog1.FileName, true))
                    {
                        file.WriteLine(report);
                    }                    
                }
                MessageBox.Show("Количество набранных баллов - " + countOfCorrectAnswers.ToString() + Environment.NewLine + "Результат сохранен в файл", "Тест пройден!");
                Close();
            }
            else
            {
                //Перейти к следующему вопросу.
                FillQuestionForm(thisTest[currentQuestion]);
                currentQuestion++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestQuestion question = thisTest[currentQuestion - 1];
            thisTest.Remove(thisTest[currentQuestion - 1]);
            thisTest.Add(question);
            FillQuestionForm(thisTest[currentQuestion - 1]);
        }
    }

    /// <summary>
    /// Класс вопроса. Содержит условие вопроса, варианты ответа и правильный вариант ответа.
    /// </summary>
    public class TestQuestion
    {
        public string question;
        public string textOfFirstVariant;
        public string textOfSecondVariant;
        public string textOfThirdVariant;
        public string textOfFourthVariant;
        public int answer;
    }

    /// <summary>
    /// Класс для десериализации теста из файла.
    /// </summary>
    [Serializable]
    public class Test
    {
        public List<TestQuestion> Questions;
    }
}
