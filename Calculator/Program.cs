using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();

            var sum = fileLogger.Add(5, 6);
            Console.WriteLine("Sum of a & b is: " + sum);
            Console.ReadLine();
        }
    }
}
