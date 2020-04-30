using System;
using System.Collections.Generic;

namespace lect14.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> neighbors = new List<Neighbor>
            {
               new Neighbor {LastName="Goro", PhoneNumber=12349995, Flat = 23 },
               new Neighbor {LastName="moro", PhoneNumber=15555345, Flat = 26 },
               new Neighbor {LastName="Goto", PhoneNumber=66637745, Flat = 29 }
            };

            Console.WriteLine("Enter flat Number: ");
            int flatNum = int.Parse(Console.ReadLine());

            Neighbor neib = neighbors.Find(item => item.Flat==flatNum);
            Console.WriteLine($"{neib.LastName}\n{neib.PhoneNumber}");


        }
    }
}
