using System;
using System.Collections;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(45); //true, boxing
            arrayList.Add(true);//true, boxing
            arrayList.Add("hello!");//false
            arrayList.Add(23.45);//true, boxing

        }
    }
}
