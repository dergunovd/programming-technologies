using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxX0.Text = "1";  // Начальное значение X0
            textBoxXk.Text = "2"; // Начальное значение Xk
            textBoxDx.Text = "0,1"; // Начальное значение Dx
            textBoxA.Text = "1"; // Начальное значение A
            textBoxB.Text = "2"; // Начальное значение B
            textBoxC.Text = "1,5"; // Начальное значение C
            // Вывод строки в многострочный редактор
            textBox4.Text = "Лаб. раб. N1. Ст. гр. 351 Дергунов Д.В.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Считывание значения переменных
                double x0 = double.Parse(textBoxX0.Text);
                double xk = double.Parse(textBoxXk.Text);
                double dx = sender.Equals(button2)
                    ? double.Parse(textBoxDx.Text) / 2
                    : double.Parse(textBoxDx.Text);
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);

                for(double x = x0; x <= xk; x += dx)
                {
                    // Вывод значения переменных в окно
                    textBox4.Text += Environment.NewLine +
                        "x = " + x.ToString();
                    double y = a * Math.Pow(x, 3) * Math.Tan(a - b * x);
                    textBox4.Text += ", y = " + y.ToString();
                }
            }
            catch (Exception)
            {
                errorProvider1.SetError(button1, "Некорректные значения переменных");
            }

        }
    }
}
