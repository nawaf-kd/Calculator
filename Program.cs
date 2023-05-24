using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Operations operations = new Operations();

            String exit;

            do
            {

                Console.WriteLine("Enter your first number:");
                Double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your Second number:");
                Double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter operation +, -, *, /. ?");
                char sign = Convert.ToChar(Console.ReadLine());

                switch (sign)
                {
                    case '+':
                        Console.WriteLine("Result = " + operations.Add(num1, num2));
                        break;
                    case '-':
                        Console.WriteLine("Result = " + operations.Sub(num1, num2));
                        break;
                    case '*':
                        Console.WriteLine("Result = " + operations.Mul(num1, num2));
                        break;
                    case '/':
                        Console.WriteLine("Result = " + operations.Div(num1, num2));
                        break;
                        default: Console.WriteLine("Please Enter an operation");
                        break;

                        

                }
                Console.WriteLine("to exit enter y  ");
                exit = Convert.ToString(Console.ReadLine());
            } while (exit != "y");

    {

            }
            Console.ReadLine();
        }
    }
}
