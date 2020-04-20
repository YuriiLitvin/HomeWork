using System;
using System.Collections.Generic;


namespace homeWork1
{
    class XmasTree
    {
        public string GetTree()
        {
            while (true)
            {
                string A = TextForWork.Get("A parameter");
                string B = TextForWork.Get("B parameter");
                int digitA = Character.GetDigit(A);
                int digitB = Character.GetDigit(B);

                if (!Character.CheckIfDigit(A) || !Character.CheckIfDigit(B))
                {
                    Console.WriteLine("You've entered character insted of digit");
                }
                else if (digitA >= digitB)
                {
                    Console.WriteLine("Sorry, but A has to be less than B");
                }
                else
                {
                    string result = PrintTree(digitA, digitB);
                    
                    TextForWork.PrintToTheFile(4, result);
                    return result;
                }
                Console.WriteLine("Please try again");
            }
        }
        
        public string PrintTree (int a, int b)
        {
            string value = "";
            for (; a <= b; a++)
            {
                for (int i = 0; i < a; i++)
                {
                    value += a;
                }
                value += "\n";
            }
            return value;
        }
    }
}
