using System;

namespace arrays7
{
    class Program
    {       
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Task_3();
        }
        static void Task_1()
        {
            Console.WriteLine("Пустой массив создать невозможно");
        }        
        static void Task_2()
        {
            object[] arr = new object[3];
            arr[0] = 32;
            arr[1] = 'a';
            arr[2] = "Hello";
            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            
            object obj1 = 10;
            arr[0] = (int)arr[0]+10;
            arr[2] += ", guys!";
            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }        
        }
        static void Task_3()
        {
            Random rnd = new Random();
            int[] arr = new int[13];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 50);
            }
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }            
            int max = arr[0];
            foreach (var item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            } 
            Console.WriteLine($"\nmax: {max}");
        }
    }
}
