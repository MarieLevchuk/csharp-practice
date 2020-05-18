using System;

namespace Lect_11.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle();
            shapes[1] = new Square();
            shapes[2] = new Triangle();

            foreach (var item in shapes)
            {
                item.AreaCalculate();
                Console.WriteLine($"This is {item.Name}.\nCLR Type is {item.GetType()}.\nSquare is {item.Area}");
            }        
        }
    }
}
