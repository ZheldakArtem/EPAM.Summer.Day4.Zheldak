using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public delegate void SortDelegate(int[][] jaggedArray);

    public static class SortOperationInterfaceToDelegate
    {
        /// <summary>
        /// This method sorts array.  
        /// </summary>
        /// <param name="array">Customer's array</param>
        /// <param name="sortInstance">Instance sorting</param>
        /// 
        private static void SortMethod(int[][] array, IComparer<int> compareInstance)
        {
            if (array == null || compareInstance == null) throw new ArgumentException();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (compareInstance.Comparer(array[j], array[j + 1]) == 1)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        public static void SortMethod(int[][] array, Func<int[], int[], int> sorterFunc)
        {
            if (array == null || sorterFunc == null)
                throw new ArgumentException();

            SortMethod(array, new SortAdapter(sorterFunc));
        }

        private class SortAdapter : IComparer<int>
        {
            private readonly Func<int[], int[], int> _sortAdapter;

            public SortAdapter(Func<int[], int[], int> sortAdapter)
            {
                if (ReferenceEquals(sortAdapter, null))
                    throw new ArgumentException();

                _sortAdapter = sortAdapter;
            }
            public int Comparer(int[] lhs, int[] rhs)
            {
                return _sortAdapter(lhs, rhs);
            }
        }
        private static void Swap(ref int[] lhs, ref int[] rhs)
        {
            var temp = lhs;
            lhs = rhs;
            rhs = temp;
        }


    }
}

