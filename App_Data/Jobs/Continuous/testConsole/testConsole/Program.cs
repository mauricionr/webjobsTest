using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
                Console.WriteLine("I'm c#..");
                Thread.Sleep(10000);
            }
        }
    }
}
