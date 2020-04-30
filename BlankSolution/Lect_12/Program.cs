using System;

namespace Lect_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto moto1 = new Moto();
            Console.WriteLine($"{Moto.Id}");

            Moto moto2 = new Moto();
            Console.WriteLine($"{Moto.Id}");

            Moto moto3 = new Moto(100);
            Console.WriteLine($"{Moto.Id}");

            Moto moto4 = new Moto(44);
            Console.WriteLine($"{Moto.Id}");

            Moto moto5 = new Moto();
            Console.WriteLine($"{Moto.Id}");
        }
    }
}
