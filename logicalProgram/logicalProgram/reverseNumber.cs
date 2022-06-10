using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalProgram
{
    internal class reverseNumber
    {
        public void Reverse_number()
        {
            Console.WriteLine("Enter the any Four digit number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int Reversed_number = 0;

            String Digits = Convert.ToString(number);

            for (int i = Digits.Length - 1; i >= 0; i--)
            {
                Reversed_number += (number % 10) * (int)Math.Pow(10, i);
                number = number / 10;


            }
            Console.WriteLine("The Reverse of given number is:" + Reversed_number);
        }

    }
}
