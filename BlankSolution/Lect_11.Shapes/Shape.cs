using System;
using System.Collections.Generic;
using System.Text;

namespace Lect_11.Shapes
{
    class Shape
    {
        public int Side { get; set; }
        public double Area { get; set; }
        public string Name { get; set; }

        public Shape()
        {
            Random rnd = new Random();
            Side = rnd.Next(1, 10);
        }

        public virtual void AreaCalculate()
        {

        }
    }
}
