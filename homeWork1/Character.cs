using System;
using System.Collections.Generic;


namespace homeWork1
{
    public static class Character
    {
        public static bool CheckIfDigit(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                bool digit = Char.IsDigit(value, i);
                if (!digit)
                {
                    return false;
                }
            }
            return true;
        }
        public static List<int> GetDigitList(string value)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < value.Length; i++)
            {
                int digit = value[i] - '0';
                list.Add(digit);
            }
            return list;
        }
        public static int GetDigit(string value) 
        {
            List<int> list = new List<int>();

            for (int i = 0; i < value.Length; i++)
            {
                int digit = value[i] - '0';
                list.Add(digit);
            }
            int[] array = list.ToArray();
            
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                number += array[i] * Convert.ToInt32(Math.Pow(10, array.Length - i - 1));
            }

            return number;

        }

        public static int GetMirror(string value)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < value.Length; i++)
            {
                int digit = value[i] - '0';
                list.Add(digit);
            }
            int[] array = list.ToArray();

            int number = 0;                             
            for (int i = 0; i < array.Length; i++)
            {
                number += array[array.Length - i - 1] * Convert.ToInt32(Math.Pow(10, array.Length - i - 1));
            }

            return number;

        }

    }   
}
