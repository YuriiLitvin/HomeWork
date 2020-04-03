using System;
using System.Text;

namespace homeWork1
{
    class SymbolCounter
    {
        public void GetSpaceSum()
        {
            //while (Console.ReadKey().Key != ConsoleKey.OemPeriod) { }

            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Enter your text: ");
            //Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                cki = Console.ReadKey();
                //Console.Write(" --- You pressed ");
                //if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                //if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                //if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                Console.Write(cki.Key.ToString());
            } while (cki.Key != ConsoleKey.OemPeriod);

        }


    }


    
}
