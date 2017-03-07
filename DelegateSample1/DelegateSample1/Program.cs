using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample1
{
    class DelegateSample
    {
        public delegate void printGreetingMsgDelegate(string s);
        public static void Main(string[] args)
        {
            printGreetingMsgDelegate del = new printGreetingMsgDelegate(PrintGreetingMessage);
            del("Ramya");
            Console.ReadLine();

        }

        public static void PrintGreetingMessage(string name)
        {
            Console.WriteLine("Hai : {0} !!! Welcome to programming world :)",name);
        }
    }
}
