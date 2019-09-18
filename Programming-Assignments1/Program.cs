using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignments1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a price:");
            string input = Console.ReadLine();
            double price = double.Parse(input);
            double vat = price * 0.21;
            double total = price + vat;
            Console.WriteLine("The price is:" + price);
            Console.WriteLine("The VAT is:" + vat);
            Console.WriteLine("The total is:" + total);
            Console.ReadKey();


        }
    }
}
