using System;

namespace Lect5.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            if(time.Hours >=9 && time.Hours < 12)
            {
                Console.WriteLine("good morning, guy");
            }
            if (time.Hours >= 12 && time.Hours < 15)
            {
                Console.WriteLine("good day, guy");
            }
            if (time.Hours >= 15 && time.Hours <= 22)
            {
                Console.WriteLine("good night, guy");
            }
            else
            {
                Console.WriteLine("it's time to sleep");
            }

            Console.WriteLine("Enter a line");
            string str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine($"count of a:{count}");
        }
    }
}
