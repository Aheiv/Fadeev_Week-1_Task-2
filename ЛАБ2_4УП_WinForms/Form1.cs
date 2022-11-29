using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ2_4УП_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 8; i >= 4; --i, richTextBox1.Text += "\n")
            {
                for (int j = 1; j <= i - 3; j++)
                {
                    richTextBox1.Text += " " + i;
                }
            }
        }
    }
}
