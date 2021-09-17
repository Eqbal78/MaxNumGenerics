using System;

namespace MaxNumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Code!");
            //Maximum Integer Number
            int[] intArray = { 34, 23, 12, 36 };
            MaxNum<int> obj = new MaxNum<int>(intArray);
            int result=obj.MaxMethod();
            Console.WriteLine("\nMaximum Integer Number is : {0}", result);

            Console.WriteLine("----------------------------------------------");

            //Maximum Float Number
            float[] floatArray = { 12.5f, 45.65f, 987.45f, 658.78f };
            MaxNum<float> obj1 = new MaxNum<float>(floatArray);
            float resultFloat = obj1.MaxMethod();
            Console.WriteLine("\nMaximum Float Number is : {0}", resultFloat);

            Console.WriteLine("----------------------------------------------");

            //Maximum String Number
            string[] stringArray = { "Apple", "Peach", "Banana", "Mango"};
            MaxNum<string> obj3 = new MaxNum<string>(stringArray);
            string resultString = obj3.MaxMethod();
            Console.WriteLine("\nMaximum Float Number is : {0}", resultString);
        }
    }
}
