using System;

namespace MaxNumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Code!");
            int result=MaxNum.Max(22, 88, 66);
            Console.WriteLine("Maximum Integer Number is : {0}", result);
        }
    }
}
