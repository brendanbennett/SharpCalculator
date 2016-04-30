using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable initialisation

            string num1;
            string num2;
            double doubleNum1;
            double doubleNum2;
            string op;
            double outputNum;
            string output = null;
            string[] acceptedOps = new string[] {"+","-","x","X","*","/","**","^"};
            bool correct = false;

            //Data input
            
            Console.WriteLine("Enter first number:");
            while (true) 
            {
                try
                {
                    num1 = Console.ReadLine();
                    doubleNum1 = Convert.ToDouble(num1);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please input a number:");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter an operator:");
                op = Console.ReadLine();
                foreach (string checkOp in acceptedOps)
                {
                    if (op == checkOp)
                    {
                        correct = true;
                        break;
                    }
                }
                if (correct == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a valid operator (+ - * / ^)");
                }
            }
            Console.WriteLine("Enter second number:");
            while (true)
            {
                try
                {
                    num2 = Console.ReadLine();
                    doubleNum2 = Convert.ToDouble(num2);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please input a number:");
                }
            }
            

            //Calculation

            switch (op)
            {
                case "+":
                    outputNum = doubleNum1 + doubleNum2;
                    output = num1 + "+" + num2 + "=" + outputNum.ToString();
                    break;
                case "-":
                    outputNum = doubleNum1 - doubleNum2;
                    output = num1 + "-" + num2 + "=" + outputNum.ToString();
                    break;
                case "x":
                case "X":
                case "*":
                    outputNum = doubleNum1 * doubleNum2;
                    output = num1 + "*" + num2 + "=" + outputNum.ToString();
                    break;
                case "/":
                    outputNum = doubleNum1 / doubleNum2;
                    output = num1 + "/" + num2 + "=" + outputNum.ToString();
                    break;
                case "**":
                case "^":
                    outputNum = Math.Pow(doubleNum1,doubleNum2);
                    output = num1 + "^" + num2 + "=" + outputNum.ToString();
                    break;
            }

            Console.WriteLine(output);
            Console.Read();
        }
    }
}
