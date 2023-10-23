using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LrPr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Вывод квадратов натуральных чисел = ДКИП-404 Авдюшин";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                int square = number * number;
                resultTextBox.Text = $"Квадрат числа {number} равен {square}";
            }
            else
            {
                resultTextBox.Text = "Пожалуйста, введите корректное натуральное число.";
            }
        }

        private void resultTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
