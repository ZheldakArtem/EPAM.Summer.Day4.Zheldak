using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace Task1.BoxClasses
{
    public class SortByMaxModule : IComparer<int>
    {
        public int Comparer(int[] lhs, int[] rhs)
        {

            if (MaxModulo(lhs) > MaxModulo(rhs))
                return 1;
            if (lhs.Max() < rhs.Max())
                return -1;
            return 0;
        }
        /// <summary>
        /// Method fineds the maximum modulus element of array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private int MaxModulo(int[] array)
        {
            int max = 0;

            for (int i = 1; i < array.Length ; i++)
            {
                max = array[0];
                if (Abs(max) < Abs(array[i]))
                {
                    max = array[i];
                }
            }

            return Abs(max);
        }
    }
}
