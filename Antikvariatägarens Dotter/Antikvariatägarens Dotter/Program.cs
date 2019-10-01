using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_Dotter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A to print info, Z to Evaluate, other key will close the program >:)");
            Bok ett = new Bok();
            start:

            string result = Console.ReadLine();

            if (result.ToUpper().Equals("A"))
            {
                ett.PrintInfo();
                Console.ReadKey();
                goto start;

            }
            else if (result.ToUpper().Equals("Z"))
            {
                ett.Evaluate();
                Console.ReadKey();
                goto start;
            }
            else
            {
                Console.WriteLine("Program will now quit due to bad behavior from user.");
                Console.ReadKey();
            }

        }
    }
}
