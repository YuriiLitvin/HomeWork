using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class Character
    {
        public bool CheckIfDigit(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                bool digit = Char.IsDigit(value, i);
                if (!digit)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
