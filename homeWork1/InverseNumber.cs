using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class InverseNumber
    {
        Character myChar = new Character();

        public string Get()
        {
            while (true)
            {
                string number = TextForWork.Get("number");

                if (!myChar.CheckIfDigit(number))
                {
                    Console.WriteLine("Sorry, number can hold only digits and can't be negative");
                }
                else
                {
                    int[] arr = myChar.GetDigitList(number).ToArray();
                    Array.Reverse(arr);
                    
                    var result = String.Join("",arr);
                    TextForWork.PrintToTheFile(5, result);
                    return result;
                }
                Console.WriteLine("Please try again");
            }
        }
        
    }
}