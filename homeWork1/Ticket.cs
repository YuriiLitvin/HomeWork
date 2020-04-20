using System;
using System.Linq;

namespace homeWork1
{
    class Ticket
    {
        private int digitСount = 6;
        
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
                else if (!Character.CheckIfDigit(ticketNumber)) 
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
            int sumFirst = Character.GetDigit(value.Substring(0,3));
            int sumLast = Character.GetDigit(value.Substring(3));

           
            
            return sumFirst == sumLast;
        }
        
    }
}
