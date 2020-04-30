using System;

namespace lect14.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Hello, guys!";
            Console.WriteLine($"{string1}\n{StringExtentions.CropString(string1)}");
        }
    }
}
