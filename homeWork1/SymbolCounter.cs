using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class SymbolCounter
    {
        public void GetSpaceSum() 
        {
            int spaceSum = 0;

            Console.WriteLine("Enter symbol:");

            foreach (string symbolLine in GetListFromInput())
            {

                //int spaceCount = symbolLine.Count(Char.IsWhiteSpace);
                //spaceSum += spaceCount;

                for (int i = 0; i < symbolLine.Length; i++)
                {
                    string str1 = symbolLine.Substring(i, 1);
                    if (str1 == " ")
                        spaceSum++;
                }

            }
            
            Console.WriteLine($"The sum of spaces is: {spaceSum}");
            Console.ReadLine();
            Console.ReadLine();


        }
        public List<string> GetListFromInput() 
        {
            List<string> inputText = new List<string>();

            while (Console.Read() != '.')
            {
                string symbolLine = Console.ReadLine();
                inputText.Add(symbolLine);
            }
            return inputText;
        }
    
    }
}
