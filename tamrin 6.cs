/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
          Console.Write("please enter number: ");
        int num = int.Parse(Console.ReadLine());

        long factorial = 1;
        
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;  // ضرب کردن فاکتوریل با هر عدد از 1 تا num
        }

        Console.WriteLine("factorial " + num + " equal: " + factorial);
    }
  }
}