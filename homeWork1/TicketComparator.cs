using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class TicketComparator
    {
        private int numberLength = 6;
        
        public void CheckLuckyTicket()
        {
            
            string ticket = CheckTicketNumber();
            int[] digitArr = new int[numberLength];

            for (int i = 0; i < numberLength; i++)
            {
                int digit = ticket[i] - '0';
                digitArr[i] = digit;
            }
            int sum1 = digitArr[0] + digitArr[1] + digitArr[2];
            int sum2 = digitArr[3] + digitArr[4] + digitArr[5];

            if (sum1 == sum2)
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
                Console.Write("Enter your ticket number: ");
                ticketNumber = Console.ReadLine();
                
                if (ticketNumber.Length != numberLength)
                {
                    Console.WriteLine("Please try again and enter correct amount of digits");
                }
                else if (CheckIfDigit(ticketNumber)) 
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
        
        public bool CheckIfDigit(string value) 
        {
            for (int i = 0; i < value.Length; i++)
            {
                bool digit = Char.IsDigit(value, i);
                if(!digit) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
