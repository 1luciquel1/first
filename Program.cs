using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Function.Factorial(s));
            Console.ReadKey();
        }
    }
}
