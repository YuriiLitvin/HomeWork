using System;
using System.Collections.Generic;


namespace homeWork1
{
    class XmasTree
    {
        Character myChar = new Character();

        
        public string GetTree()
        {
            while (true)
            {
                string A = TextForWork.Get("A parameter");
                string B = TextForWork.Get("B parameter");
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
                    string result = PrintTree(digitA, digitB);
                    //break;
                    //TextForWork.PrintToTheFile(4, result);
                    return result;
                }
                Console.WriteLine("Please try again");
            }
        }
        
        public string PrintTree (int a, int b)
        {
            string value = "";
            List<string> list = new List<string>();
            while (true)
            {
                
                for (int i = 0; i < a; i++)
                {
                    Console.Write(a);
                    value += a.ToString();
                    //list.Add(value);
                    
                }
                
                list.Add(value);
                Console.WriteLine();
                
                a++;

                if (a > b)
                {
                    //break;
                    string result = String.Join("\n", list.ToArray());
                    return result;
                }
            } 
            
        }
    }
}
