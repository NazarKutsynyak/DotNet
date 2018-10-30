using System;
using static System.Console;
using static System.Math;
using static System.Convert;


namespace Test3_OOP
{
    class Program
    {
        static void Main()
        {
            Hole hole = new Hole();
            Subject subject = new Subject();

            hole.Set();
            subject.Set();
            subject.Verication();
            

        }
    }
}
