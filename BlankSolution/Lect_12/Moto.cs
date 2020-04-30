using System;
using System.Collections.Generic;
using System.Text;

namespace Lect_12
{
    class Moto
    {
        public static int Id { get; set; }
        
        public Moto()
        {
            IdSet();
        }
        public Moto (int num)
        {
            Id = num-1;
            IdSet();
        }
        
        public static void IdSet()
        {
            Id++;
        }
    }
}
