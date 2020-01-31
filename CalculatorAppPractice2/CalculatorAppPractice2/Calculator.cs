using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    public class Calculator
    {
        private double Result;

        public double Add(double firstNumber,double secondNumber)
        {
            Result = firstNumber + secondNumber;

            return Result;
        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            Result = firstNumber - secondNumber;

            return Result;       
        }

        public double Multiply(double firstNumber, double secondNumber)
        {
            Result = firstNumber * secondNumber;

            return Result;
        }


        public double Divide(double firstNumber, double secondNumber)
        {
            Result = firstNumber/secondNumber;

            return Result;
        }


    }
}
