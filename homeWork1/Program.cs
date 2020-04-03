using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            SymbolCounter mySpace = new SymbolCounter();
            mySpace.GetSpaceSum();
            Console.ReadKey();


            //TicketComparator myTicket = new TicketComparator();
            //myTicket.CheckLuckyTicket();
            //Console.ReadKey();

            //LowerUpperCaseConverter myConverter = new LowerUpperCaseConverter();
            //myConverter.ConvertText();
            //Console.ReadKey();

            //DigitRange myRange = new DigitRange();
            //myRange.Get();
            //Console.ReadKey();

            //InverseNumber myNumber = new InverseNumber();
            //myNumber.Get();
            //Console.ReadKey();


        }

    }
}
