using System;
using System.Collections.Generic;
using System.Linq;

namespace homeWork1
{
    class TicketComparator
    {
        private int numberLength = 6;
        
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
                
                if (ticketNumber.Length != numberLength)
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
            List<int> digitList = new List<int>();

            for (int i = 0; i < value.Length; i++)
            {
                int digit = value[i] - '0';
                digitList.Add(digit);
            }
            int sumFirst = digitList.Take(3).Sum();
            int sumLast = digitList.Skip(3).Take(3).Sum();

            bool result = sumFirst == sumLast;
            
            return result;
        }
    
    
    
    
    
    }
}
