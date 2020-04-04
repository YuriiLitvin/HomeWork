using System;
using System.Text;

namespace homeWork1
{
    class SymbolCounter
    {
        public string GetSpaceSum()
        {
            Text myString = new Text();

            Console.WriteLine("Enter your symbols: ");
            Console.WriteLine("To quit enter '.'");
            int spacesCount = 0;
            while(true) 
            {
                var charToCheck = Console.ReadKey().KeyChar;

                if(charToCheck == '.') 
                {
                    break;
                }
                if (charToCheck == ' ')
                {
                    spacesCount++;
                }
            }
            string result = $"The amount of spaces is: {spacesCount}";
            myString.PrintToTheFile(1,result);
            
            return result;
        }
    }
}
