using System;
using System.Collections.Generic;
using System.Text;

namespace Lect_11.Shapes
{
    class Square : Shape
    {
        public Square()
        {
            Name = "square";
        }
        public override void AreaCalculate()
        {
            Area = Math.Pow(Side, 2);
        }
    }
}
