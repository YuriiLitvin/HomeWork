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

        
        public void Get()
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
                    Print(digitA, digitB);
                    break;
                }
                Console.WriteLine("Please try again");
            }
        }
        
        public void Print( int a, int b)
        {
            do
            {
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine(a);
                }
                a++;

                if (a > b)
                {
                    break;
                }
            } while (true);
            
            //while (a != b+1)
            //{
            //    for (int i = 0; i < a; i++)
            //    {
            //        Console.WriteLine(a);
            //    }
            //    a++;
            //}
        }
    }
}
