using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    internal class Comparefunction
    {

        public static bool CompareGrt(int x, int y)
        {
            return x > y; 

        }

        public static bool CompareLess(int x, int y)
        {
            return x < y;

        }
        public static bool SortAscending(string x, string y)
        {
            return x?.Length > y?.Length;
        }

        public static bool SortDescending (string x, string y)
        {
            return x?.Length < y?.Length;
        }
    }
}
