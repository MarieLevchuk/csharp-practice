using System;
using System.Collections.Generic;
using System.Text;

namespace lect14.Task1
{
    static class StringExtentions
    {
        public static string CropString (this string str)
        {            
            return str.Substring(0, 5) + "...";
        }
    }
}
