using System;
using System.Windows.Forms;
using System.IO;

namespace CalculatorDate
{
    public partial class Form1 : Form
    {
        string path = @"Protocol.txt";
        public Form1()
        {
            InitializeComponent();
            using (StreamWriter sw = File.CreateText(path))
            {

            }
        }

        private void buttonMonths_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator(textBoxDate1.Text, textBoxDate2.Text);
            String err1 = "", err2 = "";

            File.AppendAllText(path, "Операция Дата1-Дата2=Кол-во месяцев" + Environment.NewLine);
            File.AppendAllText(path, "Исходные данные" + Environment.NewLine);
            File.AppendAllText(path, "Дата1: " + textBoxDate1.Text + Environment.NewLine);
            File.AppendAllText(path, "Дата2: " + textBoxDate2.Text + Environment.NewLine);
            long res = calc.countMonths(ref err1, ref err2);
            if (res < 0)
            {
                File.AppendAllText(path, "Дата1: " + err1 + Environment.NewLine);
                File.AppendAllText(path, "Дата2: " + err2 + Environment.NewLine);
                textBoxMonths.Text = "Ошибка в данных. См. файл.";
            }
            else
            {
                File.AppendAllText(path, "Результат: " + res.ToString() + Environment.NewLine);
                textBoxMonths.Text = res.ToString();
            }
            File.AppendAllText(path, Environment.NewLine + Environment.NewLine);
        }

        private void buttonWeeks_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator(textBoxDate1.Text, textBoxDate2.Text);
            String err1 = "", err2 = "";
            File.AppendAllText(path, "Операция Дата1-Дата2=Кол-во недель" + Environment.NewLine);
            File.AppendAllText(path, "Исходные данные" + Environment.NewLine);
            File.AppendAllText(path, "Дата1: " + textBoxDate1.Text + Environment.NewLine);
            File.AppendAllText(path, "Дата2: " + textBoxDate2.Text + Environment.NewLine);
            long res = calc.countWeeks(ref err1, ref err2);
            if (res < 0)
            {
                File.AppendAllText(path, "Дата1: " + err1 + Environment.NewLine);
                File.AppendAllText(path, "Дата2: " + err2 + Environment.NewLine);
                textBoxWeeks.Text = "Ошибка в данных. См. файл.";
            }
            else
            {
                File.AppendAllText(path, "Результат: " + res.ToString() + Environment.NewLine);
                textBoxWeeks.Text = res.ToString();
            }
            File.AppendAllText(path, Environment.NewLine + Environment.NewLine);
        }

        private void buttonDays_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator(textBoxDate1.Text, textBoxDate2.Text);
            String err1 = "", err2 = "";
            File.AppendAllText(path, "Операция Дата1-Дата2=Кол-во дней" + Environment.NewLine);
            File.AppendAllText(path, "Исходные данные" + Environment.NewLine);
            File.AppendAllText(path, "Дата1: " + textBoxDate1.Text + Environment.NewLine);
            File.AppendAllText(path, "Дата2: " + textBoxDate2.Text + Environment.NewLine);
            long res = calc.countDays(ref err1, ref err2);
            if (res < 0)
            {
                File.AppendAllText(path, "Дата1: " + err1 + Environment.NewLine);
                File.AppendAllText(path, "Дата2: " + err2 + Environment.NewLine);
                textBoxDays.Text = "Ошибка в данных. См. файл.";
            }
            else
            {
                File.AppendAllText(path, "Результат: " + res.ToString() + Environment.NewLine);
                textBoxDays.Text = res.ToString();
            }
            File.AppendAllText(path, Environment.NewLine + Environment.NewLine);
        }

        private void buttonHours_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator(textBoxDate1.Text, textBoxDate2.Text);
            String err1 = "", err2 = "";
            File.AppendAllText(path, "Операция Дата1-Дата2=Кол-во часов" + Environment.NewLine);
            File.AppendAllText(path, "Исходные данные" + Environment.NewLine);
            File.AppendAllText(path, "Дата1: " + textBoxDate1.Text + Environment.NewLine);
            File.AppendAllText(path, "Дата2: " + textBoxDate2.Text + Environment.NewLine);
            long res = calc.countHours(ref err1, ref err2);
            if (res < 0)
            {
                File.AppendAllText(path, "Дата1: " + err1 + Environment.NewLine);
                File.AppendAllText(path, "Дата2: " + err2 + Environment.NewLine);
                textBoxHours.Text = "Ошибка в данных. См. файл.";
            }
            else
            {
                File.AppendAllText(path, "Результат: " + res.ToString() + Environment.NewLine);
                textBoxHours.Text = res.ToString();
            }
            File.AppendAllText(path, Environment.NewLine + Environment.NewLine);
        }

        private void buttonMinutes_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator(textBoxDate1.Text, textBoxDate2.Text);
            String err1 = "", err2 = "";
            File.AppendAllText(path, "Операция Дата1-Дата2=Кол-во минут" + Environment.NewLine);
            File.AppendAllText(path, "Исходные данные" + Environment.NewLine);
            File.AppendAllText(path, "Дата1: " + textBoxDate1.Text + Environment.NewLine);
            File.AppendAllText(path, "Дата2: " + textBoxDate2.Text + Environment.NewLine);
            long res = calc.countMinutes(ref err1, ref err2);
            if (res < 0)
            {
                File.AppendAllText(path, "Дата1: " + err1 + Environment.NewLine);
                File.AppendAllText(path, "Дата2: " + err2 + Environment.NewLine);
                textBoxMinutes.Text = "Ошибка в данных. См. файл.";
            }
            else
            {
                File.AppendAllText(path, "Результат: " + res.ToString() + Environment.NewLine);
                textBoxMinutes.Text = res.ToString();
            }
            File.AppendAllText(path, Environment.NewLine + Environment.NewLine);
        }

        private void buttonSeconds_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator(textBoxDate1.Text, textBoxDate2.Text);
            String err1 = "", err2 = "";
            File.AppendAllText(path, "Операция Дата1-Дата2=Кол-во секунд" + Environment.NewLine);
            File.AppendAllText(path, "Исходные данные" + Environment.NewLine);
            File.AppendAllText(path, "Дата1: " + textBoxDate1.Text + Environment.NewLine);
            File.AppendAllText(path, "Дата2: " + textBoxDate2.Text + Environment.NewLine);
            long res = calc.countSeconds(ref err1, ref err2);
            if (res < 0)
            {
                File.AppendAllText(path, "Дата1: " + err1 + Environment.NewLine);
                File.AppendAllText(path, "Дата2: " + err2 + Environment.NewLine);
                textBoxSeconds.Text = "Ошибка в данных. См. файл.";
            }
            else
            {
                File.AppendAllText(path, "Результат: " + res.ToString() + Environment.NewLine);
                textBoxSeconds.Text = res.ToString();
            }
            File.AppendAllText(path, Environment.NewLine + Environment.NewLine);
        }

        private void buttonProtocol_Click(object sender, EventArgs e)
        {
            textBoxProtocol.Text = "";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    textBoxProtocol.Text += (s + Environment.NewLine);
                }
            }
        }
    }
}
