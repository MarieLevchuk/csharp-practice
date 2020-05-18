using System;
using System.Collections.Generic;
using System.Text;

namespace Lect_11.Shapes
{
    class Triangle : Shape
    {
        public Triangle()
        {
            Name = "triangle";
        }
        public override void AreaCalculate()
        {
            Area = Side * Side * Math.Sqrt(3) / 4;
        }

    }
}
