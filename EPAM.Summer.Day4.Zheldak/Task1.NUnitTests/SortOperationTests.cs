using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;
using Task1.BoxClasses;

namespace Task1.NUnitTests
{
    public class SortOperationTests
    {
        [Test]
        public void SortBySummRowsAscend()
        {
            IComparer sortJagged = new SortBySumAscend();

            int[][] jaggedArray =
                {
                    new[] {1,3,5,7,9},
                    new[] {0,2,4,0},
                    new[] {11,22}
               };

            int[][] result =
               {
                    new[] {0,2,4,0},
                    new[] {1,3,5,7,9},
                    new[] {11,22}
               };

            SortOperationInterfaceToDelegate.SortMethod(jaggedArray, sortJagged);
           
            CollectionAssert.AreEqual(jaggedArray, result);
        }
        
        [Test]
        public void SortByMaxModuleElements()
        {
            IComparer sortJagged = new SortByMaxModule();

            int[][] jaggedArray =
                {
                    new[] {1,3,5,7,-9},
                    new[] {11,-22},
                    new[] {0,2,4,0}
                };

            int[][] result =
               {
                   new[] {0,2,4,0},
                   new[] {1,3,5,7,-9},
                   new[] {11,-22},
               };

            SortOperationInterfaceToDelegate.SortMethod(jaggedArray, sortJagged);
           
            CollectionAssert.AreEqual(jaggedArray, result);
        }

        [Test]
        public void SortWithDelegateToInterfaceSumRow()
        {
            IComparer sortJagged = new SortBySumAscend();

            int[][] jaggedArray =
               {
                    new[] {1,3,5,7,9},
                    new[] {0,2,4,0},
                    new[] {11,22}
               };

            int[][] result =
               {
                    new[] {0,2,4,0},
                    new[] {1,3,5,7,9},
                    new[] {11,22}
               };
            SortOperationDelegateToInterface.SortMethodDelegate(jaggedArray, sortJagged.Sort);
            CollectionAssert.AreEqual(jaggedArray, result);
        }

        [Test]
        public void SortWithDelegetToInterfaceMaxModule()
        {
           IComparer sortJagged = new SortByMaxModule();

            int[][] jaggedArray =
               {
                    new[] {1,3,5,7,-9},
                    new[] {11,-22},
                    new[] {0,2,4,0}
                };

            int[][] result =
               {
                   new[] {0,2,4,0},
                   new[] {1,3,5,7,-9},
                   new[] {11,-22},
               };
            SortOperationDelegateToInterface.SortMethodDelegate(jaggedArray, sortJagged.Sort);
            CollectionAssert.AreEqual(jaggedArray, result);
        }
    }
}

