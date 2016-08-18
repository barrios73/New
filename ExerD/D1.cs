using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerD
{
    class D1
    {
        static void Main(string[] args)
        {
            int inputNumber;

            do
            {
                Console.Write("Please enter an integer number: \t");
                inputNumber = Convert.ToInt32(Console.ReadLine());

            } while (inputNumber != 88);

            Console.WriteLine("Lucky you...");

        }
    }
}
