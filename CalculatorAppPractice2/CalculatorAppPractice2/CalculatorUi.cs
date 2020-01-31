using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        public CalculatorUi()
        {
            InitializeComponent();
        }

        Calculator calculator = new Calculator();

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Validation Check

            if (String.IsNullOrEmpty(firstNumberTextBox.Text))
            {
                MessageBox.Show("Firt number cannot be empty!");
                return;
            }

            if (String.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Second number cannot be empty!");
                return;
            }

            if (!String.IsNullOrEmpty(resultTextBox.Text))
            {
                MessageBox.Show("result must be empty!");
                resultTextBox.Clear();
                return;
            }
            
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Add(firstNumber, secondNumber).ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            //Validation Check

            if (String.IsNullOrEmpty(firstNumberTextBox.Text))
            {
                MessageBox.Show("Firt number cannot be empty!");
                return;
            }

            if (String.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Second number cannot be empty!");
                return;
            }

            if (!String.IsNullOrEmpty(resultTextBox.Text))
            {
                MessageBox.Show("result must be empty!");
                resultTextBox.Clear();
                return;
            }
            
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);           

            resultTextBox.Text = calculator.Subtract(firstNumber, secondNumber).ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            //Validation Check

            if (String.IsNullOrEmpty(firstNumberTextBox.Text))
            {
                MessageBox.Show("Firt number cannot be empty!");
                return;
            }

            if (String.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Second number cannot be empty!");
                return;
            }

            if (!String.IsNullOrEmpty(resultTextBox.Text))
            {
                MessageBox.Show("result must be empty!");
                resultTextBox.Clear();
                return;
            }
            
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Multiply(firstNumber, secondNumber).ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            //Validation Check

            if (String.IsNullOrEmpty(firstNumberTextBox.Text))
            {
                MessageBox.Show("Firt number cannot be empty!");
                return;
            }

            if (String.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Second number cannot be empty!");
                return;
            }

            if (!String.IsNullOrEmpty(resultTextBox.Text))
            {
                MessageBox.Show("result must be empty!");
                resultTextBox.Clear();
                return;
            }
            
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Divide(firstNumber, secondNumber).ToString();
        }
    }
}
