﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     public  class SortOperationDelegateToInterface
    {
        /// <summary>
        /// This method sorts array.  
        /// </summary>
        /// <param name="array">Customer's array</param>
        /// <param name="sorting">It's delegate parameter</param>
        public static void SortMethodDelegate(int[][] array, SortDelegate sorting)
        {
            var sortedJagged = (IComparer) sorting.Target;
            SortMethod(array,sortedJagged);
        }


        private static void SortMethod(int[][] array, IComparer sortInstance)
        {
            sortInstance.Sort(array);
        }
    }
}
