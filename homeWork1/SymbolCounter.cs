using System;
using System.Text;

namespace homeWork1
{
    class SymbolCounter
    {
        public void GetSpaceSum()
        {
            int i = 0;
            
            do
            {
                if (Console.ReadKey().Key != ConsoleKey.Spacebar)
                {
                    i++;
                }

            } while (Console.ReadKey().Key != ConsoleKey.OemPeriod);
            Console.WriteLine(i);
        }


    }


    
}
