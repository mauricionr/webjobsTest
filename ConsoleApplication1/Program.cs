using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleApplication2.Dummy dummy = new ConsoleApplication2.Dummy();

            while(true)
            { 
                Console.WriteLine("Test 1");
                Thread.Sleep(10000);
            }
        }
    }
}
