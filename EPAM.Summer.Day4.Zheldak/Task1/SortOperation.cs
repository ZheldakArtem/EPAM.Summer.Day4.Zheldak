using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static public class SortOperation
    {
        /// <summary>
        /// This method sorts array.  
        /// </summary>
        /// <param name="array">Customer's array</param>
        /// <param name="sortInstance">Instance sorting</param>
        public static void SortMethod(int[][] array, ISortJagged sortInstance)
        {
            sortInstance.Sort(array);
        }
    }
}

