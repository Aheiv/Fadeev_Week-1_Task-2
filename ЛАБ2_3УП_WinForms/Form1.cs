using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ2_3УП_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int x;

            if (numericUpDown3.Value < 0)
            {
                MessageBox.Show("Некорректный ввод данных!");
                return;
            }
            a = int.Parse(numericUpDown1.Text);
            b = int.Parse(numericUpDown2.Text);
            x = int.Parse(numericUpDown3.Text);
            richTextBox1.Text = "Диапазон чисел, оканчивающихся на цифру " + x + ": ";
            for (int i = a; i < b + 1; i++)
            {
                if (Math.Abs(i) % 10 == x) richTextBox1.Text += (i + ",");
                else continue;
            }
        }
    }
}
