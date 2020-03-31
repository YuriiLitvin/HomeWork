using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    public class InputString
    {
        public string Get(string text)
        {
            Console.Write($"Enter your {text}: ");
            string value = Console.ReadLine();

            return value;
        }

    }
}
