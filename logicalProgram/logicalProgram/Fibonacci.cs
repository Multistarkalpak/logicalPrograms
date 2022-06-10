using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalProgram
{
    internal class Fibonacci
    {
            
        public int num1 = 0;
        public int num2 = 1;

        public void fibonacci()
        {
            int n = 8;
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            for (int i = 1; i <=n; i++)
            {
                int newNum = num1 + num2;

                Console.WriteLine(newNum);

                num1 = num2;
                num2 = newNum;

            }
        }
    }
}
