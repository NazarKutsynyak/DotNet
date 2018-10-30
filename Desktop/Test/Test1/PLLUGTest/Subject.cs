using System;
using static System.Console;
using static System.Math;
using static System.Convert;

namespace Test3_OOP
{
    class Subject
    {
        public int Form;
        private double BallDiameter;
        private double CylinderDiameter, CylinderHeight;
        private double CubeWidth, CubeHeight, CubeDepth;

        public void Set()
        {
            WriteLine("Виберіть форму предмету, який хочете просунути через отвір");
            WriteLine("Якщо куб введіть 1\nЯкщо куля введіть 2");
            WriteLine("Якщо циліндр введіть 3");

            string input = ReadLine();
            int temp = 0;

            if (Int32.TryParse(input, out temp))
            {
                Form = temp;

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
            else
            {
                WriteLine("\n!!!Ви ввели некоректне значення!!! Програма завершить роботу. Натисніть любу кнопку.\n");
                ReadKey();
                Environment.Exit(0);
            }
        }

        private double Radius()
        {
            double p = 0;
            double r = 0;
            p = (Hole.Triangle.edgeA + Hole.Triangle.edgeB + Hole.Triangle.edgeC) / 2;
            r = Sqrt(((p - Hole.Triangle.edgeA) * (p - Hole.Triangle.edgeB) * (p - Hole.Triangle.edgeC)) / p);
            return r;
        }

        private void VerificationBall(int FormOfHole, double a, double b, double c)
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

            if (FormOfHole == 3)
            {
                
                if(Radius() <= (BallDiameter/2))
                {
                    WriteLine("");


                }
            }
        }

        private void VerificationCylinder(int FormOfHole, double a, double b, double c)
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

        private void VerificationCube(int FormOfHole, double a, double b, double c)
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

        public void Verication()
        {
            if (Hole.Form == 1)
            {
                if (Form == 1)
                {
                    VerificationCube(Hole.Form, Hole.Rectangle.Width, Hole.Rectangle.Height, 0);
                }

                if (Form == 2)
                {
                    VerificationBall(Hole.Form, Hole.Rectangle.Width, Hole.Rectangle.Height, 0);
                }

                if (Form == 3)
                {
                    VerificationCylinder(Hole.Form, Hole.Rectangle.Width, Hole.Rectangle.Height, 0);
                }
            }

            if (Hole.Form == 2)
            {
                if (Form == 1)
                {
                    VerificationCube(Hole.Form, Hole.Ring.Diameter, 0, 0);
                }

                if (Form == 2)
                {
                    VerificationBall(Hole.Form, Hole.Ring.Diameter, 0, 0);
                }

                if (Form == 3)
                {
                    VerificationCylinder(Hole.Form, Hole.Ring.Diameter, 0, 0);
                }
            }

            if(Hole.Form == 3)
            {
                if(Form == 1)
                {
                    VerificationCube(Hole.Form, Hole.Triangle.edgeA, Hole.Triangle.edgeB, Hole.Triangle.edgeC);
                }

                if(Form == 2)
                {
                    VerificationBall(Hole.Form, Hole.Triangle.edgeA, Hole.Triangle.edgeB, Hole.Triangle.edgeC);
                }

                if(Form == 3)
                {
                    VerificationCylinder(Hole.Form, Hole.Triangle.edgeA, Hole.Triangle.edgeB, Hole.Triangle.edgeC);
                }
            }
        }
    }
}
