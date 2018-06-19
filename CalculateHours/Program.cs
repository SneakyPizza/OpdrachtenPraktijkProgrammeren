using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHours
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculate the amout of Hours/Minutes/Seconds to seconds, input h/m/s as pref starting value");
                char select = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                double num;

                switch (select)
                {
                    case 'h':
                        Console.WriteLine("Input the amount of hours: ");
                        num = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 'm':
                        Console.WriteLine("Input the amount of minutes: ");
                        num = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 's':
                        Console.WriteLine("Input the amount of seconds: ");
                        num = Convert.ToDouble(Console.ReadLine());
                        break;
                }
            }
        }
    }
}
