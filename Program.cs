using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoledata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;//value type
            Console.WriteLine(num);
            object obj; //reference type
            obj = num;//boxing
            Console.WriteLine(obj);
            int num2;
            num2 = (int)obj;//unboxing
            Console.ReadKey();
        }
    }
}
