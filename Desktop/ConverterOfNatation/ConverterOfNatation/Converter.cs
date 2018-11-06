using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ConverterOfNatation
{
    class Converter
    {
        private Dictionary<int, string> Letters = new Dictionary<int, string>(26)
        {
            {10, "A"},
            {11, "B"},
            {12, "C"},
            {13, "D"},
            {14, "E"},
            {15, "F"},
            {16, "G"},
            {17, "H"},
            {18, "I"},
            {19, "J"},
            {20, "K"},
            {21, "L"},
            {22, "M"},
            {23, "N"},
            {24, "O"},
            {25, "P"},
            {26, "Q"},
            {27, "R"},
            {28, "S"},
            {29, "T"},
            {30, "U"},
            {31, "V"},
            {32, "W"},
            {33, "X"},
            {34, "Y"},
            {35, "Z"}

        };

        double Result = 0;
        private List<int> NumberForConvertation = new List<int>();
        private string temp = "";

        private void Set()
        {
            WriteLine("Привіт. Ця програма конвертує значення з системи числення з основою 35.");

            WriteLine("Введіть число, яке хочете конвертувати");
            temp = ReadLine().ToUpper();
        }

        private void ConvertationToNumber()
        {
            //temp = temp.Replace(temp.ToUpper);
            for(int i = 0; i < temp.Length; i++)
            {               
                foreach(KeyValuePair<int, string> key in Letters)
                {
                    if(temp[i] == Convert.ToChar(key.Value))
                    {
                        //WriteLine(key.Key);
                        NumberForConvertation.Add(key.Key);
                    }
                    
                }
                for(int j = 0; j < 10; j++)
                {                    
                    if (j == (int)Char.GetNumericValue(temp[i]))
                    {
                        //WriteLine("j " + temp[i]);
                        NumberForConvertation.Add((int)Char.GetNumericValue(temp[i]));
                    }
                }
                //WriteLine(NumberForConvertation[i]);
            }
        }

        private void ConvertationToNatation()
        {
            for(int i = 0,  power = NumberForConvertation.Count; i < NumberForConvertation.Count; i++, power--)
            {
                Result += NumberForConvertation[i] * Pow(35, power - 1);
                //WriteLine(power);
            }
        }

        private void Print()
        {
            WriteLine(Result);
        }

        public void Run()
        {
            Set();
            ConvertationToNumber();
            ConvertationToNatation();
            Print();
        }
    }
}
