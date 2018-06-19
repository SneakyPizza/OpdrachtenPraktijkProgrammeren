using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcBtw
{
    class Program
    {
       private const double BTW_PERCENTAGE = 0.19;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter price: ");

                double _price = Convert.ToDouble(Console.ReadLine()); // User Input
                Console.Clear();

                Console.WriteLine("Btw: " + BTW_PERCENTAGE);
                double btwprice = BTW_PERCENTAGE * _price;
                Console.WriteLine("BTW value: " + btwprice);
                Console.WriteLine("Total value: " + _price + btwprice);
            }
        }
    }
}
