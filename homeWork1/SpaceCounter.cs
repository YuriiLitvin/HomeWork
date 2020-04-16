using System;
using System.Text;

namespace homeWork1
{
    class SpaceCounter
    {
        public string GetCount()
        {
            Console.WriteLine("Enter your symbols: ");
            Console.WriteLine("To quit enter '.'");
            int spaceCount = 0;
            while(true) 
            {
                var charToCheck = Console.ReadKey().KeyChar;

                if(charToCheck == '.') 
                {
                    break;
                }
                if (charToCheck == ' ')
                {
                    spaceCount++;
                }
            }
            string result = $"The amount of spaces is: {spaceCount}";
            TextForWork.PrintToTheFile(1,result);
            
            return result;
        }
    }
}
