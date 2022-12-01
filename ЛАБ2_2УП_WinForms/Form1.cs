using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ2_2УП_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NMonths; // кол-во месяцев

            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Некорректный ввод данных!");
                return;
            }
            NMonths = int.Parse(numericUpDown1.Text);
            switch (1 > 0)
            {
                case true:
                    var oldDate = DateTime.Now.AddMonths(-NMonths);
                    dateTimePicker2.Value = oldDate;
                    dateTimePicker2.Visible = true;
                    break;
            }
        }
    }
}
