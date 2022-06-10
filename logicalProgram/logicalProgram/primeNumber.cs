using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalProgram
{
    internal class primeNumber
    {
        public void primenumber()
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            for ( i = 2; i < number; i++)
            {
                if (number%i==0)
                {
                    Console.WriteLine("{0} is Not a Prime", number);

                    break;
                }
            }

            if(i==number)
            {
                Console.WriteLine("{0} is Prime", number);
            }
        }

    }
}
