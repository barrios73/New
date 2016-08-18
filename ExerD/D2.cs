using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerD
{
    class D2
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int largerNumber;
            int smallerNumber;
            int a;
            int b;
            int HCF;
            int LCM;

            Console.Write("Please enter the first integer number: \t");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second integer number (must be different " +
                "from first number: \t");
            secondNumber = Convert.ToInt32(Console.ReadLine());


            a = firstNumber;
            b = secondNumber;

            while (a != b)
            {
                if (a > b)
                {
                    largerNumber = a - b;
                    smallerNumber = b;
                }
                else
                {
                    largerNumber = b - a;
                    smallerNumber = a;
                }

                 a = largerNumber;
                 b = smallerNumber;
                    
            }

            



            HCF = a;            
            LCM = firstNumber * secondNumber / HCF;

            Console.WriteLine("The HCF is {0}", HCF);
            Console.WriteLine("The LCM is {0}", LCM);
        }
    }
}
