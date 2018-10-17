using System;


namespace PLLUGTest
{
    class Program
    {
        static int FormOfHole = 0, FormOfObject = 0;
        static double RectangleWidth = 0, RectangleHeight = 0, RingDiameter = 0;
        static double CubeWidth = 0, CubeHeight = 0, CubeDepth = 0;
        static double BallDiameter = 0;
        static double CylinderDiameter = 0, CylinderHeight = 0;

        static void SetHole()
        {
            do
            {
                Console.WriteLine("Привіт! Введи будьласка форму отвору");
                Console.WriteLine("Якщо прямокутник, введи 1");
                Console.WriteLine("Якщо круг, введи 2");

                FormOfHole = Convert.ToInt32(Console.ReadLine());

                if (FormOfHole == 1)
                {
                    Console.WriteLine("Ви вибрали прямокутник");

                    Console.WriteLine("Введіть ширину (формат х,хх):");
                    RectangleWidth = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введіть висоту (формат х,хх): ");
                    RectangleHeight = Convert.ToDouble(Console.ReadLine());
                }
                else if (FormOfHole == 2)
                {
                    Console.WriteLine("Ви вибрали круг");

                    Console.WriteLine("Введіть діаметр (формат х,хх): ");
                    RingDiameter = Convert.ToDouble(Console.ReadLine());
                }
            } while (FormOfHole < 1 && FormOfHole > 2);
        }

        static void SetObject()
        {
            Console.WriteLine("Виберіть форму предмету, який хочете просунути через отвір");
            Console.WriteLine("Якщо куб введіть 1\nЯкщо куля введіть 2");
            Console.WriteLine("Якщо циліндр введіть 3");

            FormOfObject = Convert.ToInt32(Console.ReadLine());

            if (FormOfObject == 1)
            {
                Console.WriteLine("Ви вибрали куб");

                Console.WriteLine("Введіть ширину:");
                CubeWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введіть висоту:");
                CubeHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введіть глибину:");
                CubeDepth = Convert.ToDouble(Console.ReadLine());
            }
            else if (FormOfObject == 2)
            {
                Console.WriteLine("Ви вибрали кулю");

                Console.WriteLine("Введіть діаметр кулі:");
                BallDiameter = Convert.ToDouble(Console.ReadLine());
            }
            else if (FormOfObject == 3)
            {
                Console.WriteLine("Ви вибрали цилінд");

                Console.WriteLine("Введіть діаметр:");
                CylinderDiameter = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введіть висоту:");
                CylinderHeight = Convert.ToDouble(Console.ReadLine());
            }
        }

        static void VerificationRectangle() 
        {
            if (FormOfObject == 1)
            {
                if (RectangleWidth > CubeWidth && RectangleHeight > CubeHeight)
                    Console.WriteLine("Ви можете просунути цей куб.");

                else if (RectangleWidth > CubeHeight && RectangleHeight > CubeWidth)
                    Console.WriteLine("Ви можете просунути цей куб, але вам потрібно його повернути");


                else if (RectangleWidth > CubeWidth && RectangleHeight > CubeDepth)
                    Console.WriteLine("Ви можете просунути цей куб, але вам потрібно його повернути");

                else if (RectangleWidth > CubeDepth && RectangleHeight > CubeWidth)
                    Console.WriteLine("Ви можете просунути цей куб, але вам потрібно його повернути");


                else if (RectangleWidth > CubeHeight && RectangleHeight > CubeDepth)
                    Console.WriteLine("Ви можете просунути цей куб, але вам потрібно його повернути");

                else if (RectangleWidth > CubeDepth && RectangleHeight > CubeHeight)
                    Console.WriteLine("Ви можете просунути цей куб, але вам потрібно його повернути");


                else Console.WriteLine("Ви не зможете просути цей куб");
            }

            else if(FormOfObject == 2)
            {
                if (RectangleWidth > BallDiameter && RectangleHeight > BallDiameter)
                    Console.WriteLine("Ви можете просунути цю кулю");

                else Console.WriteLine("Ви не зможете пронути цю кулю");
            }

            else if(FormOfObject == 3)
            {
                if (RectangleWidth > CylinderDiameter && RectangleHeight > CylinderHeight)
                    Console.WriteLine("Ви можете просунути цей циліндр");
                else if (RectangleWidth > CylinderHeight && RectangleHeight > CylinderDiameter)
                    Console.WriteLine("Ви можете просунути цей циліндр, але вам потрібно його повернути");
                else if (RectangleWidth > CylinderDiameter && RectangleHeight > CylinderDiameter)
                    Console.WriteLine("Ви можете просунути цей циліндр, але вам потрібно його повернути");
                else Console.WriteLine("Ви не зможете просунути цей циліндр");
            }
            
        }

        static void VerificationRing()
        {
            if (FormOfObject == 1)
            {
                double CubeHypotenuseA = Math.Sqrt((CubeWidth * CubeWidth) + (CubeHeight * CubeHeight));
                double CubeHypotenuseB = Math.Sqrt((CubeWidth * CubeWidth) + (CubeDepth * CubeDepth));
                double CubeHypotenuseC = Math.Sqrt((CubeHeight * CubeHeight) + (CubeDepth * CubeDepth));

                if (RingDiameter > CubeHypotenuseA)
                    Console.WriteLine("Цей прямокутник пролізе в отвір");
                else if (RingDiameter > CubeHypotenuseB)
                    Console.WriteLine("Цей прямокутник пролізе в отвір, але вам потрібно його повернути");
                else if (RingDiameter > CubeHypotenuseC)
                    Console.WriteLine("Цей прямокутник пролізе в отвір, але вам потрібно його повернути");
                else Console.WriteLine("Цей прямокутник не пролізе в отвір");
            }
            else if (FormOfObject == 2)
            {
                if (RingDiameter > BallDiameter)
                    Console.WriteLine("Ця куля пролізе в отвір");
                else Console.WriteLine("Ця куля не пролізе в отвір");
            }
            else if(FormOfObject == 3)
            {
                double CylinderHypotenuse = Math.Sqrt((CylinderDiameter * CylinderDiameter) + (CylinderHeight * CylinderHeight));

                if (RingDiameter > CylinderHypotenuse)
                    Console.WriteLine("Цей циліндр пролізе в отвір");
                else if (RingDiameter > CylinderDiameter)
                    Console.WriteLine("Цей циліндр пролізе в отвір");
                else Console.WriteLine("Цей циліндр не пролізе в отвір");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            //SetHole();
            FormOfHole = 2;
            RingDiameter = 100;
            //SetObject();
            FormOfObject = 3;
            CylinderDiameter = 100;
            CylinderHeight = 100;
            if (FormOfHole == 1) VerificationRectangle();
            else VerificationRing();
        }
    }
}