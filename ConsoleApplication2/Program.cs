using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCalculator
{
    class Calculator
    {
        public static double InputNum()
        {

        Console.WriteLine("Enter number:");
            while (true)
            {
                try
                {
                    string num = Console.ReadLine();
                    double doubleNum = Convert.ToDouble(num);
                    return doubleNum;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please input a number:");
                }
            }
        }

        //Operations

        public static double Add(double firstNum)
        {
            double secondNum = InputNum();
            return firstNum + secondNum;
        }

        public static double Minus(double firstNum)
        {
            double secondNum = InputNum();
            return firstNum - secondNum;
        }

        public static double Multi(double firstNum)
        {
            double secondNum = InputNum();
            return firstNum * secondNum;
        }

        public static double Divide(double firstNum)
        {
            double secondNum = InputNum();
            return firstNum / secondNum;
        }

        public static double PowerOf(double firstNum)
        {
            double secondNum = InputNum();
            return Math.Pow(firstNum,secondNum);
        }

        //main
        static void Main(string[] args)
        {
            //Variable initialisation
            string op;
            double firstNum;
            bool AvailableOp = false;
            string[] acceptedOps = new string[] {"+","-","x","X","*","/","**","^"};


            //Data input

            firstNum = Calculator.InputNum();

            while (true)
            {
                Console.WriteLine("Enter an operator:");
                op = Console.ReadLine();
                foreach (string checkOp in acceptedOps)
                {
                    if (op == checkOp)
                    {
                        AvailableOp = true;
                        break;
                    }
                }
                if (AvailableOp == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a valid operator (+ - * / ^)");
                }
            }


            double outputNum = 0.0;
            //Calculation
            
            switch (op)
            {
                case "+":
                    outputNum = Calculator.Add(firstNum);
                    break;
                case "-":
                    outputNum = Calculator.Minus(firstNum);
                    break;
                case "x":
                case "X":
                case "*":
                    outputNum = Calculator.Multi(firstNum);
                    break;
                case "/":
                    outputNum = Calculator.Divide(firstNum);
                    break;
                case "**":
                case "^":
                    outputNum = Calculator.PowerOf(firstNum);
                    break;
            }

            Console.WriteLine(outputNum);
            Console.Read();
        }
    }
}
