using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibonacci_recursive_function
{
    class Program
    {
          static int fibonacci(int n)
        {
            if (n==0)
            {
                return 0;
            }
            else if (n==1)
            {
                return 1;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2); 
            }
          
        }
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("plesase enter number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("fibonaci is :{0}",fibonacci(n));
            Console.ReadKey();
        }
    }
}
