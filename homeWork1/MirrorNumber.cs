using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class MirrorNumber
    {

        public string GetNumber()
        {
            while (true)
            {
                string unconvertedNumber = TextForWork.Get("number");

                if (!Character.CheckIfDigit(unconvertedNumber))
                {
                    Console.WriteLine("Sorry, number can hold only digits and can't be negative");
                }
                else
                {
                    int numberReversed = Character.GetMirror(unconvertedNumber);
                    
                    string result = numberReversed.ToString();

                    TextForWork.PrintToTheFile(5, result);
                    return result;
                }
                Console.WriteLine("Please try again");
            }
        }
        
    }
}