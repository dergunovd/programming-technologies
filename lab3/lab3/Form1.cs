using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3,4";  // Начальное значение X
            textBox2.Text = "20,74"; // Начальное значение Y
            // Вывод строки в многострочный редактор
            textBox4.Text = "Лаб. раб. N1. Ст. гр. 351 Дергунов Д.В.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Считывание значения переменных
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);

                // Вывод значения переменных в окно
                textBox4.Text += Environment.NewLine +
                    "X = " + x.ToString();
                textBox4.Text += Environment.NewLine +
                    "Y = " + y.ToString();

                // Определяем f(x)
                double f;
                if (radioButton2.Checked)
                {
                    f = Math.Sinh(x);
                }
                else if (radioButton2.Checked)
                {
                    f = x * x;
                }
                else
                {
                    f = Math.Exp(x);
                }

                // Высчитываем значение системы
                double c;
                double cond = x - y;
                if (cond == 0)
                {
                    c = f * f + y * y + Math.Sin(x);
                }
                else if(cond > 0)
                {
                    c = Math.Pow(f - y, 2) + Math.Cos(y);
                }
                else
                {
                    c = Math.Pow(y - f, 2) + Math.Tan(y);
                }
                
                // Выводим результат в окно
                textBox4.Text += Environment.NewLine +
                    "Результат C = " + c.ToString();
            }
            catch (Exception)
            {
                errorProvider1.SetError(button1, "Некорректные значения переменных");
            }

        }
    }
}
