using System;
using static System.Console;
using static System.Math;
using static System.Convert;


namespace Test3_OOP
{
    class Hole
    {
        public int Form;
        public double RingDiameter, RectangleWidth, RectangleHeight;

        public void Set()
        {
            WriteLine("Привіт! Введи будьласка форму отвору");
            WriteLine("Якщо прямокутник, введи 1");
            WriteLine("Якщо круг, введи 2");

            Form = ToInt32(ReadLine());

            if (Form == 1)
            {
                WriteLine("Ви вибрали прямокутник");

                WriteLine("Введіть ширину (формат х,хх):");
                RectangleWidth = ToDouble(ReadLine());

                WriteLine("Введіть висоту (формат х,хх): ");
                RectangleHeight = ToDouble(ReadLine());
            }
            else if (Form == 2)
            {
                WriteLine("Ви вибрали круг");

                WriteLine("Введіть діаметр (формат х,хх): ");
                RingDiameter = ToDouble(ReadLine());
            }

        }


    }
    class Object
    {
        public int Form;
        public double BallDiameter;
        public double CylinderDiameter, CylinderHeight;
        public double CubeWidth, CubeHeight, CubeDepth;

        public void Set()
        {
            WriteLine("Виберіть форму предмету, який хочете просунути через отвір");
            WriteLine("Якщо куб введіть 1\nЯкщо куля введіть 2");
            WriteLine("Якщо циліндр введіть 3");

            Form = ToInt32(ReadLine());

            if (Form == 1)
            {
                Console.WriteLine("Ви вибрали куб");

                Console.WriteLine("Введіть ширину:");
                CubeWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введіть висоту:");
                CubeHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введіть глибину:");
                CubeDepth = Convert.ToDouble(Console.ReadLine());
            }
            else if (Form == 2)
            {
                WriteLine("Ви вибрали кулю");

                WriteLine("Введіть діаметр кулі:");
                BallDiameter = ToDouble(ReadLine());
            }
            else if (Form == 3)
            {
                WriteLine("Ви вибрали цилінд");

                WriteLine("Введіть діаметр:");
                CylinderDiameter = ToDouble(ReadLine());

                WriteLine("Введіть висоту:");
                CylinderHeight = ToDouble(ReadLine());
            }
        }

        public void VerificationBall(int FormOfHole, double a, double b)
        {
            if (FormOfHole == 1)
            {
                if (a > BallDiameter && b > BallDiameter)
                    WriteLine("Ви можете просунути цю кулю");

                else WriteLine("Ви не зможете пронути цю кулю");
            }
            if (FormOfHole == 2)
            {
                if (a > BallDiameter)
                    WriteLine("Ця куля пролізе в отвір");
                else WriteLine("Ця куля не пролізе в отвір");
            }
        }

        public void VerificationCylinder(int FormOfHole, double a, double b)
        {
            if (FormOfHole == 1)
            {
                if (a > CylinderDiameter && b > CylinderHeight)
                    Console.WriteLine("Ви можете просунути цей циліндр");
                else if (a > CylinderHeight && b > CylinderDiameter)
                    Console.WriteLine("Ви можете просунути цей циліндр, але вам потрібно його повернути");
                else if (a > CylinderDiameter && b > CylinderDiameter)
                    Console.WriteLine("Ви можете просунути цей циліндр, але вам потрібно його повернути");
                else Console.WriteLine("Ви не зможете просунути цей циліндр");
            }
            if (FormOfHole == 2)
            {
                double CylinderHypotenuse = Math.Sqrt((CylinderDiameter * CylinderDiameter) + (CylinderHeight * CylinderHeight));

                if (a > CylinderHypotenuse)
                    Console.WriteLine("Цей циліндр пролізе в отвір");
                else if (a > CylinderDiameter)
                    Console.WriteLine("Цей циліндр пролізе в отвір");
                else Console.WriteLine("Цей циліндр не пролізе в отвір");
            }
        }

        public void VerificationCube(int FormOfHole, double a, double b)
        {
            if (FormOfHole == 1)
            {
                if (a > CubeWidth && b > CubeHeight)
                    Console.WriteLine("Ви можете просунути цей куб.");

                else if (a > CubeHeight && b > CubeWidth)
                    Console.WriteLine("Ви можете просунути цей куб, але вам потрібно його повернути");


                else if (a > CubeWidth && b > CubeDepth)
                    Console.WriteLine("Ви можете просунути цей куб, але вам потрібно його повернути");

                else if (a > CubeDepth && b > CubeWidth)
                    Console.WriteLine("Ви можете просунути цей куб, але вам потрібно його повернути");


                else if (a > CubeHeight && b > CubeDepth)
                    Console.WriteLine("Ви можете просунути цей куб, але вам потрібно його повернути");

                else if (a > CubeDepth && b > CubeHeight)
                    Console.WriteLine("Ви можете просунути цей куб, але вам потрібно його повернути");


                else Console.WriteLine("Ви не зможете просути цей куб");
            }
            if (FormOfHole == 2)
            {
                double CubeHypotenuseA = Math.Sqrt((CubeWidth * CubeWidth) + (CubeHeight * CubeHeight));
                double CubeHypotenuseB = Math.Sqrt((CubeWidth * CubeWidth) + (CubeDepth * CubeDepth));
                double CubeHypotenuseC = Math.Sqrt((CubeHeight * CubeHeight) + (CubeDepth * CubeDepth));

                if (a > CubeHypotenuseA)
                    Console.WriteLine("Цей прямокутник пролізе в отвір");
                else if (a > CubeHypotenuseB)
                    Console.WriteLine("Цей прямокутник пролізе в отвір, але вам потрібно його повернути");
                else if (a > CubeHypotenuseC)
                    Console.WriteLine("Цей прямокутник пролізе в отвір, але вам потрібно його повернути");
                else Console.WriteLine("Цей прямокутник не пролізе в отвір");
            }
        }


    }

    class Program
    {
        static void Main()
        {
            Hole hole = new Hole();
            Object obj = new Object();

            hole.Set();
            obj.Set();

            if (hole.Form == 1)
            {
                if (obj.Form == 1) obj.VerificationCube(hole.Form, hole.RectangleWidth, hole.RectangleHeight);
                if (obj.Form == 2) obj.VerificationBall(hole.Form, hole.RectangleWidth, hole.RectangleHeight);
                if (obj.Form == 3) obj.VerificationCylinder(hole.Form, hole.RectangleWidth, hole.RectangleHeight);
            }
            if (hole.Form == 2)
            {
                if (obj.Form == 1) obj.VerificationCube(hole.Form, hole.RingDiameter, 0);
                if (obj.Form == 2) obj.VerificationBall(hole.Form, hole.RingDiameter, 0);
                if (obj.Form == 3) obj.VerificationCylinder(hole.Form, hole.RingDiameter, 0);
            }

        }
    }
}
