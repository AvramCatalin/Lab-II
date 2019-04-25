using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExThree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float firstNumber;
        float secondNumber;
        public bool OperationsSolver()
        {
            firstNumber = 0f;
            bool allIsGood = true;
            try
            {
                firstNumber = float.Parse(textBox_FirstNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong type of value given to First Number!");
                allIsGood = false;
            }
            secondNumber = 0f;
            try
            {
                secondNumber = float.Parse(textBox_SecondNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong type of value given to Second Number!");
                allIsGood = false;
            }
            return allIsGood;
        }
        private void AdditionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(OperationsSolver())
            {
                textBox_Result.Text = string.Format("{0:N3}", (firstNumber + secondNumber));
            }
            else
            {
                textBox_Result.Text = "";
            }

        }
        private void SubtractionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (OperationsSolver())
            {
                textBox_Result.Text = string.Format("{0:N3}", (firstNumber - secondNumber));
            }
            else
            {
                textBox_Result.Text = "";
            }
        }
        private void MultiplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (OperationsSolver())
            {
                textBox_Result.Text = string.Format("{0:N3}", (firstNumber * secondNumber));
            }
            else
            {
                textBox_Result.Text = "";
            }
        }
        private void DivisionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (OperationsSolver())
            {
                textBox_Result.Text = string.Format("{0:N3}", (firstNumber / secondNumber));
            }
            else
            {
                textBox_Result.Text = "";
            }
        }
    }
}
