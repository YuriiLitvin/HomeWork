using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class DigitRange
    {
        Text myString = new Text();
        Character myChar = new Character();

        
        public string Get()
        {
            while (true)
            {
                string A = myString.Get("A parameter");
                string B = myString.Get("B parameter");
                int digitA = myChar.GetDigit(A);
                int digitB = myChar.GetDigit(B);

                if (!myChar.CheckIfDigit(A) || !myChar.CheckIfDigit(B))
                {
                    Console.WriteLine("You've entered character insted of digit");
                }
                else if (digitA >= digitB)
                {
                    Console.WriteLine("Sorry, but A has to be less than B");
                }
                else
                {
                    string result = Print(digitA, digitB);

                    myString.PrintToTheFile(4,result);
                    return result;
                }
                Console.WriteLine("Please try again");
            }
        }
        
        public string Print( int a, int b)
        {
            List<string> list = new List<string>();
            while (true)
            {
                for (int i = 0; i < a; i++)
                {
                    string value = a.ToString();
                    list.Add(value);
                    
                }
                a++;

                if (a > b)
                {
                    string result = String.Join(String.Empty, list.ToArray());
                    return result;
                }
            } 
            
        }
    }
}
