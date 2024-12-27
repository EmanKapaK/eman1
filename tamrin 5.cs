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


        string numStr = num.ToString();
        int digitCount = numStr.Length;

       
        Console.WriteLine("number of digit: " + digitCount);
    }
  }
}