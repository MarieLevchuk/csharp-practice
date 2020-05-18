using System;
using System.Collections.Generic;
using System.Text;

namespace Lect_11.Shapes
{
    class Circle : Shape
    {
        public Circle()
        {
            Name = "circle";
        }
        public override void AreaCalculate()
        {           
            Area = Math.PI * Side * Side / 4;
        }
    }
}
