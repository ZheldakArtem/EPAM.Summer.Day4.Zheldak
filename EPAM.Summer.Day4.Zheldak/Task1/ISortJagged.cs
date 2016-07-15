using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IComparer<T>
    {
       T Comparer(T[] lhs, T[] rhs);
    }
}
