using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3.delgate
{

    internal static  class Helper
    {
        public static List<T> GetElementBasedOnPassedFunction<T>(List<T> Element , Predicate <T> condition)
        {
            List<T> result = new List<T>();
            if (Element is not null && condition is not null)
               for (int i = 0; i < Element.Count; i++)
                    if (condition(Element[i]))
                        result.Add(Element[i]);

            return result;
        }
   /*     public static List<int> GetEvenNumber(List<int> Number)
        {
            List<int> result = new List<int>();
            if (Number is not null)
                for (int i = 0; i < Number.Count; i++)
                    if (Number[i] % 2 == 0)
                        result.Add(i);

            return result;
        }
        public static List<int> GetdivisiableBy7 (List<int> Number)
        {
            List<int> result = new List<int>();
            if (Number is not null)
                for (int i = 0; i < Number.Count; i++)
                    if (Number[i] % 7 == 0)
                        result.Add(i);

            return result;
        }*/
    }
}

