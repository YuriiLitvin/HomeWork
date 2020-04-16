using System;
using System.Linq;

namespace homeWork1
{
    class TicketComparator
    {
        private int digitСount = 6;
        
        Character myChar = new Character();

        public string CheckIfLucky()
        {
            string ticket = CheckIfCorrect();

            if (CheckIfEqual(ticket))
            {
                string result = "Congratulations! You have a lucky ticket!";
                TextForWork.PrintToTheFile(2,result);
                return result;
            }
            else
            {
                string result = "Sorry. Your ticket isn't lucky";
                TextForWork.PrintToTheFile(2, result);
                return result;

            }

        }
        
        public string CheckIfCorrect()
        {
            string ticketNumber;
            
            while (true)
            {
                ticketNumber = TextForWork.Get("ticket number");
                
                if (ticketNumber.Length != digitСount)
                {
                    Console.WriteLine("You've entered incorrect amount of digits");
                }
                else if (!myChar.CheckIfDigit(ticketNumber)) 
                {
                    Console.WriteLine("You've entered character insted of digit");
                }
                else
                {
                    break;
                }
                Console.WriteLine("Please try again");
            }
            return ticketNumber;
        }
        
        public bool CheckIfEqual(string value) 
        {
            int sumFirst = myChar.GetDigit(value.Substring(0,3));
            int sumLast = myChar.GetDigit(value.Substring(3));

            bool result = sumFirst == sumLast;
            
            return result;
        }
        
    }
}
