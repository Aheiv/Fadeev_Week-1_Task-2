using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ2_1_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            double y;
            x = double.Parse(numericUpDown1.Text);
            y = double.Parse(numericUpDown2.Text);
            if (y > 0 || y < -100 || x > 100 || x < -100 || 1 / 2 * x * y > 5000)
                textBox1.Text = "Вне";
            else if (y < 0 && y > -100 && x < 100 && x > -100 && 1 / 2 * x * y < 5000)
                textBox1.Text = "Внутри";
            else textBox1.Text = "На границе";
        }
    }
}
