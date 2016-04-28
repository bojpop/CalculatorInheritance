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
        override public int Add(int a, int b)
        {
            Console.WriteLine("Logging in file");
            int res = base.Add(5, 6);
            Console.WriteLine("Result is: ", res);
            return res;
        }
    }
}
