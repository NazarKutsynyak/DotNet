using System;
using static System.Console;
using static System.Math;
using static System.Convert;

namespace Test3_OOP
{
    class Hole
    {
        public static int Form { get; set; }
  
        public class Ring
        {
            public static double Diameter { get; set; }

            public static void Set()
            {
                WriteLine("Ви вибрали круг");

                WriteLine("Введіть діаметр (формат х,хх): ");
                Diameter = ToDouble(ReadLine());
            }
        }

        public class Rectangle
        {
            public static double Width { get; set; }
            public static double Height { get; set; }

            public static void Set()
            {
                WriteLine("Ви вибрали прямокутник");

                WriteLine("Введіть ширину (формат х,хх): ");
                Width = ToDouble(ReadLine());

                WriteLine("Введіть висоту (формат х,хх): ");
                Height = ToDouble(ReadLine());
            }

        }

        public class Triangle
        {
            public static double edgeA { get; set; }
            public static double edgeB { get; set; }
            public static double edgeC { get; set; }

            public static void Set()
            {
                WriteLine("Ви вибрали трикутник");

                WriteLine("Введіть сторону А (формат х,хх): ");
                edgeA = ToDouble(ReadLine());

                WriteLine("Введіть сторону В (формат х,хх): ");
                edgeB = ToDouble(ReadLine());

                WriteLine("Введіть сторону С (формат х,хх): ");
                edgeC = ToDouble(ReadLine());
            }
        }
        
        public void Set()
        {
            
            WriteLine("Привіт! Введіть будьласка форму отвору");
            WriteLine("Якщо круг, введіть 1");
            WriteLine("Якщо прямокутник, введіть 2");
            WriteLine("Якщо трикутник, введіть 3");
            string input = ReadLine();
            int temp = 0;

            do
            {

                if (Int32.TryParse(input, out temp))
                {
                    if (temp < 4 && temp > 0)
                    {
                        Form = temp;

                        if (Form == 1)
                        {
                            Ring.Set();
                        }

                        if (Form == 2)
                        {
                            Rectangle.Set();
                        }

                        if (Form == 3)
                        {
                            Triangle.Set();
                        }
                        break;
                    }
                    else
                    {
                        WriteLine("__!!!!!Ви ввели некоректне значення!!!!!___");
                    }
                }
                else
                {
                    WriteLine("\n!!!Ви ввели некоректне значення!!! Програма завершить роботу. Натисніть любу кнопку.\n");
                    ReadKey();
                    Environment.Exit(0);

                }

            } while (true);
        }
    }
}
