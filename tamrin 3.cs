/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
     int a = 0 ;
     int b=0;
     int temp =0;
    Console.Write("enter 1 numbers:");
    a = int.Parse(Console.ReadLine());
    Console.Write("enter 2 numbers:");
    b = int.Parse(Console.ReadLine());
    temp =a;
    a=b;
    b=temp;
    
  }
}