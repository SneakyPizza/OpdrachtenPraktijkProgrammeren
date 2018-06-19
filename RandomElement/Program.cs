using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomElement
{
    class Program
    {
        static void Main(string[] args)
        {
            AddElements();
        }

        private static void AddElements()
        {
            double[] _elements = new double[20];
            Random num = new Random();
            for (int i = 0; i < _elements.Length; i++)
            {
                _elements[i] = num.Next(maxValue: 200, minValue: 0);
                Console.WriteLine(_elements[i]);
            }
            Console.ReadLine();
            AvarageElements(_elements, _elements.Length);
            
        }

        private static void AvarageElements(double[] arr, int size)
        {
            double sum = 0;
            double average = 0;
           
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }

            average = sum / size;

            Console.WriteLine("Sum Of Array is : " + sum);
            Console.WriteLine("Average Of Array is : " + average);
            Console.ReadLine();
            CheckDiffrence(arr, average);
            
        }

        private static void CheckDiffrence(double[] arr, double avg)
        {
            foreach(double element in arr)
            {
                double a = Math.Abs(element - avg);
                Console.WriteLine("Diffrence is: " + a);
            }
            Console.ReadLine();
        }
    }
}
