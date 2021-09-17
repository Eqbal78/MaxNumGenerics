using System;

namespace MaxNumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Code!");
            //Maximum Integer Number
            MaxNum<int> obj = new MaxNum<int>(22, 88, 66);
            int result=obj.MaxMethod();
            Console.WriteLine("\nMaximum Integer Number is : {0}", result);

            Console.WriteLine("----------------------------------------------");

            //Maximum Float Number
            MaxNum<float> obj1 = new MaxNum<float>(12.2f, 1.8f, 9.6f);
            float resultFloat = obj1.MaxMethod();
            Console.WriteLine("\nMaximum Float Number is : {0}", resultFloat);

            Console.WriteLine("----------------------------------------------");

            //Maximum String Number
            MaxNum<string> obj3 = new MaxNum<string>("Apple", "Peach", "Mango");
            string resultString = obj3.MaxMethod();
            Console.WriteLine("\nMaximum Float Number is : {0}", resultString);
        }
    }
}
