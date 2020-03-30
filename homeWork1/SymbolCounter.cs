using System;
using System.Collections.Generic;

namespace homeWork1
{
    class SymbolCounter
    {
        public string GetSpaceSum() 
        {
            int spaceSum = 0;
            bool spaceExist;
            Console.WriteLine("Enter your text:");

            foreach (char symbol in GetListFromInput()) 
            {
                if (spaceExist = symbol.Equals(' ')) 
                {
                    spaceSum++;
                } 
                
                
                
                //for (int i = 0; i < symbolLine.Length; i++)
                //{
                //    string str1 = symbolLine.Substring(i, 1);
                //    if (str1 == " ")
                //        spaceSum++;
                //}

            }
            return $"\nThe sum of spaces is: {spaceSum}";
        }
        
        
        
        public List<char>  GetListFromInput() 
        {
            List<char> inputList = new List<char>();
            
            char symbol = Console.ReadKey().KeyChar;

            while (true)
            {
                //char symbol = Console.ReadLine()[0];
                if (symbol != '.') 
                {
                    inputList.Add(symbol);
                }
                
            }
            return inputList;
        }
    
    }
}
