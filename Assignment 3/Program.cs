using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of seconds:");
            string input = Console.ReadLine();
            double nrOfSeconds = double.Parse(input);

            Console.WriteLine("You entered: " + nrOfSeconds + " seconds");


            int seconds = Convert.ToInt32(nrOfSeconds);

            int hours = seconds / 3600;
            int minutes = (seconds - hours * 3600) / 60;
            int seconds2 = ((seconds - hours * 3600) - minutes * 60) * 1;

            Console.WriteLine(hours + ":" + minutes + ":" + seconds2);

            Console.ReadKey();

        }
    }
}
