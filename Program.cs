using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.WriteLine("{0} {1}",a,b);
            for(int i = 0; i <10; i++) 
            {
                c = a + b;
                Console.WriteLine("{0}",c);
                a = b;
                b = c;
            }
            Console.ReadKey(); 

        }
    }
}
