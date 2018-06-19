using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenteCalc
{
    class Program
    {
        static void Main(string[] args)
        { 
                string input;
                input = Console.ReadLine();
                double inleg = double.Parse(input);

                input = Console.ReadLine();
                double rente = double.Parse(input);

                input = Console.ReadLine();
                double looptijd = double.Parse(input);

                double eindkapitaal = 0;

                for (int teller = 0; teller < looptijd; teller++)
                {
                    eindkapitaal = eindkapitaal + inleg;
                    eindkapitaal = eindkapitaal * (1 + rente / 100);
                }

                Console.WriteLine(eindkapitaal);
                Console.ReadLine();
        }
    }
}
