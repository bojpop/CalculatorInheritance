using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class FileLogger : Calculator
    {
        private Calculator calc = new Calculator();
            int Add(int a, int b)
            {
                Console.WriteLine("Logging in file");
                return calc.Add(a,b);
            }
    }
}
