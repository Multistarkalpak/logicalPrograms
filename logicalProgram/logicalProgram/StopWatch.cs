using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalProgram
{
    internal class StopWatch
    {
        public void Stop_Watch()
        {
            Console.WriteLine("Plese Enter to Start. ");
            Console.ReadLine();
            DateTime Start = DateTime.Now;

            Console.WriteLine("Please Enter to stop.");
            Console.ReadLine();
            DateTime End = DateTime.Now;

            Console.Write("Elased time = " + (End - Start));
        }
    }
}
