using System;
using System.Linq;

namespace homeWork1
{
    class TicketComparator
    {
        private int digitAmount = 6;
        
        Text myString = new Text();
        Character myChar = new Character();

        public string CheckLuckyTicket()
        {
            string ticket = CheckCorrectInput();

            if (GetDigitSum(ticket))
            {
                string result = "Congratulations! You have a lucky ticket!";
                myString.PrintToTheFile(2,result);
                return result;
            }
            else
            {
                string result = "Sorry. Your ticket isn't lucky";
                myString.PrintToTheFile(2, result);
                return result;

            }

        }
        
        public string CheckCorrectInput()
        {
            string ticketNumber;
            
            while (true)
            {
                ticketNumber = myString.Get("ticket number");
                
                if (ticketNumber.Length != digitAmount)
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
        
        public bool GetDigitSum(string value) 
        {
            int sumFirst = myChar.GetDigitList(value).Take(3).Sum();
            int sumLast = myChar.GetDigitList(value).Skip(3).Take(3).Sum();

            bool result = sumFirst == sumLast;
            
            return result;
        }
        
    }
}
