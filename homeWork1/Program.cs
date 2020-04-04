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
            var answer1 = mySpace.GetSpaceSum();
            Console.WriteLine(answer1);


            TicketComparator myTicket = new TicketComparator();
            var answer2 = myTicket.CheckLuckyTicket();
            Console.WriteLine(answer2);

            LowerUpperCaseConverter myConverter = new LowerUpperCaseConverter();
            var answer3 = myConverter.ConvertText();
            Console.WriteLine(answer3);

            DigitRange myRange = new DigitRange();
            var answer4 = myRange.Get();
            Console.WriteLine(answer4);

            InverseNumber myNumber = new InverseNumber();
            var answer5 = myNumber.Get();
            Console.WriteLine(answer5);


        }

    }
}
