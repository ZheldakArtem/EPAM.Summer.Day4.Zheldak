using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1
{
     public  class SortOperationDelegateToInterface
    {
        /// <summary>
        /// This method sorts array.  
        /// </summary>
        /// <param name="array">Customer's array</param>
        /// <param name="sorting">It's delegate parameter</param>
        private static void SortMethodDelegate(int[][] array, Func<int[],int[],int> comparerFunc)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (comparerFunc(array[j], array[j + 1]) == 1)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// This method call SortMethodDelegate.  
        /// </summary>
        /// <param name="array">Customer's array</param>
        /// <param name="compareInstance">It's parameter comparer</param>
        public static void SortMethod(int[][] array,IComparer<int> compareInstance)
        {
            if (array == null || compareInstance == null)
            {
                throw new ArgumentException();
            }

            SortMethodDelegate(array,compareInstance.Comparer);
        }

        private static void Swap(ref int[] lhs, ref int[] rhs)
        {
            var temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
