using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class InverseNumber
    {
        InputString myString = new InputString();
        Character myChar = new Character();

        public void Get()
        {
            while (true)
            {
                string number = myString.Get("number");

                if (!myChar.CheckIfDigit(number))
                {
                    Console.WriteLine("Sorry, number can hold only digits and can't be negative");
                }
                else
                {
                    string inverseNumber = Inverse(number);
                    Console.WriteLine(myChar.GetDigit(inverseNumber)); 
                    break;
                }
                Console.WriteLine("Please try again");
            }
        }
        
        public string Inverse(string value) 
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }
    
    
    }
}