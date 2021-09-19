using System;

namespace MaxNumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Code!");

            int result=MaxNum.Max(22, 88, 66);
            Console.WriteLine("\nMaximum Integer Number is : {0}", result);

            Console.WriteLine("----------------------------------------------");

            float resultFloat = MaxNum.Max(12.2f, 1.8f, 9.6f);
            Console.WriteLine("\nMaximum Float Number is : {0}", resultFloat);

            Console.WriteLine("----------------------------------------------");

            string resultString = MaxNum.Max("Apple", "Banana", "Mango");
            Console.WriteLine("\nMaximum Float Number is : {0}", resultString);
        }
    }
}
