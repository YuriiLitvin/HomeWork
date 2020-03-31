using System;
using System.Collections.Generic;
using System.Linq;

namespace homeWork1
{
    class TicketComparator
    {
        private int digitAmout = 6;
        
        InputString myString = new InputString();
        Character myChar = new Character();

        public void CheckLuckyTicket()
        {
            string ticket = CheckTicketNumber();

            if (GetDigitSum(ticket))
            {
                Console.WriteLine("Congratulations! You have a lucky ticket!");
            }
            else
            {
                Console.WriteLine("Sorry. Your ticket isn't lucky");
            }

        }
        
        public string CheckTicketNumber()
        {
            string ticketNumber;
            
            while (true)
            {
                ticketNumber = myString.Get("ticket number");
                
                if (ticketNumber.Length != digitAmout)
                {
                    Console.WriteLine("Please try again and enter correct amount of digits");
                }
                else if (myChar.CheckIfDigit(ticketNumber)) 
                {
                    Console.WriteLine("You've entered character insted of digit. Please try again");
                }
                else
                {
                    break;
                }
            }
            return ticketNumber;
        }
        
        public bool GetDigitSum(string value) 
        {
            int sumFirst = myChar.ConvertToDigit(value).Take(3).Sum();
            int sumLast = myChar.ConvertToDigit(value).Skip(3).Take(3).Sum();

            bool result = sumFirst == sumLast;
            
            return result;
        }
        
    }
}
