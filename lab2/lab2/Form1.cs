using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3,74e-2";  // Начальное значение X
            textBox2.Text = "-0,825"; // Начальное значение Y
            textBox3.Text = "0,16e2";// Начальное значение Z
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
                double z = double.Parse(textBox3.Text);

                // Вывод значения переменных в окно
                textBox4.Text += Environment.NewLine +
                    "X = " + x.ToString();
                textBox4.Text += Environment.NewLine +
                    "Y = " + y.ToString();
                textBox4.Text += Environment.NewLine +
                    "Z = " + z.ToString();

                // Вычисляем арифметическое выражение
                double a = 1 + Math.Pow(Math.Sin(x + y), 2);
                double b = Math.Abs(x - (2 * y) / (1 + Math.Pow(x * y, 2)));
                a = a / b * Math.Pow(x, Math.Abs(y));
                double c = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

                double u = a + c;
                // Выводим результат в окно
                textBox4.Text += Environment.NewLine +
                    "Результат U = " + u.ToString();
            }
            catch (Exception)
            {
                errorProvider1.SetError(button1, "Некорректные значения переменных");
            }
            
        }
    }
}