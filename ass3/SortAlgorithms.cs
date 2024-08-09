using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    //public delegate bool CompareFuncDelagte <T>(T a, T b);
    internal class SortAlgorithms<T>
    {
        #region non - genaric
     /*   public static void Bubblesort(int[] array, CompareFuncDelagte compareFunc)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (compareFunc(array[j], array[j + 1]))
                            Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }*/
        #endregion
        public static void Bubblesort(T[] array, Func<T,T,bool> compareFunc)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (compareFunc(array[j], array[j + 1]))
                            Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        private static void Swap(ref T v1, ref T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
