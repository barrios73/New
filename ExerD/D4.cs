using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExerD
{
    class D4
    {
        static void Main(string[] args)
        {

            double inputNumber;
            double G;
            Random rnd1 = new Random();

            Console.Write("Please enter the number you would like to determine the square root: \t");
            inputNumber = Convert.ToDouble(Console.ReadLine());

            G = inputNumber * rnd1.NextDouble();

            while (G * G - inputNumber > 0.00001 || inputNumber - G*G > 0.00001)
            
                //Alternatively use the absolute function
                // Math.Abs(G*G - inputNumber) > 0.00001 in the while loop

                G = (G + inputNumber / G)/2;

            Console.WriteLine("The square root of {0} is {1:0.00000}", inputNumber, G);

        }
    }
}
