using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    internal class StringFunction
    {
        public static int GetCountUpperChars(string Name)
        {
            int count = 0;
            if (Name is not null)
            
                for (int i = 0; i < Name.Length; i++)
                
                    if (char.IsUpper(Name[i]))
                        count++;

                    return count; 
        }

        /*public static int GetCountLowerChars(string Name)
        {
            int count = 0;
            if (Name is not null)

                for (int i = 0; i < Name.Length; i++)

                    if (char.IsLower(Name[i]))
                        count++;

            return count;


        }*/
    }
}
