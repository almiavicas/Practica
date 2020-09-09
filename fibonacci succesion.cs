//fibonacci Succesion
using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
           int descendant = 0;
           int actual = 1;
           int fibonacciSuccesion;

           for (int i = 1; i < 20; i++)
           {
               fibonacciSuccesion = actual + descendant;
               descendant = actual;
               actual = fibonacciSuccesion;
               Console.WriteLine(fibonacciSuccesion);
           }  
        }
    }
} 