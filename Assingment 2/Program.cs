using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            string input1 = Console.ReadLine();
            double nr1 = double.Parse(input1);
            Console.WriteLine("Enter 2nd number");
            string input2 = Console.ReadLine();
            double nr2 = double.Parse(input2);
            Console.WriteLine("Enter 3rd number");
            string input3 = Console.ReadLine();
            double nr3 = double.Parse(input3);

            Console.WriteLine("Your first number is " + nr1);
            Console.WriteLine("Your second number is " + nr2);
            Console.WriteLine("Your third number is " + nr3);

            double total = nr1 + nr2 + nr3;

            Console.WriteLine("The total of the aforementioned numbers is " + total);

            double average = total / 3;

            Console.WriteLine("The average of the aforementioned numbers is " + average);
            Console.ReadKey();


        }
    }
}
