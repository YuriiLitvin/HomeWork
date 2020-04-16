using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class LowerUpperCaseConverter
    {
        private const int A = 65;
        private const int Z = 90;
        private const int a = 97;
        private const int z = 122;
        private const int difference = 32;

        public string ConvertText()
        {
            string input = TextForWork.Get("text");

            string result = GetUpLowCase(input);
            TextForWork.PrintToTheFile(3, result);
           
            return $"Your result text is: {result}";
        }
        

        public string GetUpLowCase(string value) 
        {
            string result = "";
            for (int i = 0; i < value.Length; i++)
            {
                int decimValue = value[i];
                if (decimValue >= A && decimValue <= Z)
                {
                    decimValue += difference;
                }
                else if (decimValue >= a && decimValue <= z)
                {
                    decimValue -= difference;
                }

                result += Convert.ToChar(decimValue);
            }
            return result;
        }
    }
}
