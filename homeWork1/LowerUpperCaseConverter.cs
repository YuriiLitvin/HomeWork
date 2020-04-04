using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class LowerUpperCaseConverter
    {
        Text myString = new Text();
        public string ConvertText()
        {
            string input = myString.Get("text");

            string result = String.Join("", CheckUpLowCase(input).ToArray());

            myString.PrintToTheFile(3,result);
            return $"Your result text is: {result}";
        }
        

        public List<char> CheckUpLowCase(string value) 
        {
            List<char> list = new List<char>();

            for (int i = 0; i < value.Length; i++)
            {
                int decimValue = value[i];
                if (decimValue >= 65 && decimValue <= 90)
                {
                    decimValue += 32;
                }
                else if (decimValue >= 97 && decimValue <= 122)
                {
                    decimValue -= 32;
                }
                char result = Convert.ToChar(decimValue);
                list.Add(result);
            }
            return list;
        }
    }
}
