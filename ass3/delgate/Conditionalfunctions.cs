using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3.delgate
{
    internal class Conditionalfunctions
    {
        public static bool CheckOdd (int number )
        {
            return number % 2 == 1;
        }
        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }
        public static bool CheckDivisiableby7(int number)
        {
            return number % 7 == 0;
        }
        public static bool CheckDivisiableby10(int number)
        {
            return number % 10 == 0;
        }
        public static bool CheckStringLength (string Word)
        {
            return Word?.Length > 4;
        }
    }
}
