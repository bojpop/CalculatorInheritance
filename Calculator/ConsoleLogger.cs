using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ConsoleLogger
    {
        private Calculator calc = new Calculator();
        override public int Add(int a, int b)
        {
            Console.WriteLine("Logging in console");
            return calc.Add(a, b);
        }
    }
}
