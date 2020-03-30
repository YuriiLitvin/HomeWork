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
            //SymbolCounter symCount = new SymbolCounter();
            //Console.WriteLine(symCount.GetSpaceSum());
            //Console.ReadKey();

            //FileTxt file = new FileTxt();
            //file.Create();

            TicketComparator myTicket = new TicketComparator();
            myTicket.CheckLuckyTicket();
            Console.ReadKey();

        }
    }
}
