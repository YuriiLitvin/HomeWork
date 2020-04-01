using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    public class Character
    {
        public bool CheckIfDigit(string value)
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
        public List<int> GetDigitList(string value)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < value.Length; i++)
            {
                int digit = value[i] - '0';
                list.Add(digit);
            }
            return list;
        }
        public int GetDigit(string value) 
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



    }   
}
