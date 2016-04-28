using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ConsoleLogger : Calculator
    {
        private Calculator calc = new Calculator();
        override public int Add(int a, int b)
        {
            Console.WriteLine("Logging in console");
            int res = base.Add(5, 6);
            Console.WriteLine("Result is: ", res);
            return res;
        }
    }
}
