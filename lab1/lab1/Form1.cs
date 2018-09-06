using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            label.Visible = sender.Equals(showBtn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            label.Text = "Начало работы";
        }
    }
}
