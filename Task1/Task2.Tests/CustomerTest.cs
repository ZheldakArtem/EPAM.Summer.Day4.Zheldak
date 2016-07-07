using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2.Tests
{
    public class CustomerTest
    {
        [Test]
        public void CustomerGlobalTest()
        {
            Customer customer=new Customer("Zinedin Zidane","+375445673606",234527);
           
            Assert.AreEqual(customer.ToString(), "Customer record: Zinedin Zidane 234 527,00₽ +375445673606");
        }


    }
}
