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
        public static void SortMethod(int[][] array, ISortJagged sortInstance)
        {
            if (array == null || sortInstance == null)
                throw new ArgumentException();
            SortMethodDelegate(array, sortInstance.Sort);
        }

        private static void SortMethodDelegate(int[][] array, SortDelegate sorting)
        {
            sorting(array);
        }

    }
}

