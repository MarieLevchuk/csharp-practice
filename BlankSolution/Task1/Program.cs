using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1 = 10;
            object obj1 = num1;
            sbyte num2 = (sbyte)(short)obj1;
            Console.WriteLine(num2);
            Console.WriteLine(num2.GetType());


        }
    }
}
