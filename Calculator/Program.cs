using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    { 
            static double num1;
            static double num2;
        static void Main(string[] args)
        {
            string input;
            char _operator;
            input = Console.ReadLine();
            num1 = double.Parse(input);
            input = Console.ReadLine();
            _operator = char.Parse(input);
            input = Console.ReadLine();
            num2 = double.Parse(input);


            switch (_operator)
            {
                case '+':
                    double result = TelOp(num1, num2);
                    Console.WriteLine(result);
                    break;
                case '.':
                    double resultAf = TrekAf(num1, num2);
                    Console.WriteLine(resultAf);
                    break;
                case '*':
                    double resultK = Vermenigvuldig(num1, num2);
                    Console.WriteLine(resultK);
                    break;
                case '/':

                    double resultD = Deel(num1, num2);
                    Console.WriteLine(resultD);
                    break;
            }
            Console.Read();
        }

        static double TelOp(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        static double TrekAf(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        static double Vermenigvuldig(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        static double Deel(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
