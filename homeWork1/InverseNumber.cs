using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class InverseNumber
    {
        Text myString = new Text();
        Character myChar = new Character();

        public string Get()
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
                    string result = Inverse(number);
                    //var result = myChar.GetDigit(inverseNumber);

                    myString.PrintToTheFile(5,result);
                    return result;
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