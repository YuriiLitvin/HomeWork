using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class LowerUpperCaseConverter
    {

        public void ConvertText()
        {
            Console.Write("Enter your text: ");
            string inputString = Console.ReadLine();

            string result = String.Join("", ConvertChar(inputString).ToArray());

            Console.WriteLine($"Your result text is: {result}");
        }
        

        public List<char> ConvertChar(string value) 
        {
            List<char> charList = new List<char>();

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
                char resultChar = Convert.ToChar(decimValue);
                charList.Add(resultChar);
            }
            return charList;
        }
    }
}
