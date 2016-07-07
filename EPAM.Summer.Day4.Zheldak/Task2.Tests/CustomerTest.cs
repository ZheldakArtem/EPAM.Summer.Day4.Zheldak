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
        public void ConstructorTest()
        {
            var customer = new Customer("Zinedin Zidane", "+375445673606", 234527);

            Assert.AreEqual(customer.Name, "Zinedin Zidane");
            Assert.AreEqual(customer.Revenue, 234527);
            Assert.AreEqual(customer.ContactPhone, "+375445673606");
        }

        [TestCase("{0:NRP}", ExpectedResult = "Customer record: Zinedin Zidane 234 527,00₽ +375445673606")]
        [TestCase("{0:NR}", ExpectedResult = "Customer record: Zinedin Zidane 234 527,00₽")]
        [TestCase("{0:N}", ExpectedResult = "Customer record: Zinedin Zidane")]
        [TestCase("{0:P}", ExpectedResult = "Customer record: +375445673606")]
        public string CustomerGlobalTest_WithStringFormat(string format)
        {
            var customer = new Customer("Zinedin Zidane", "+375445673606", 234527);
            string resultCustomer = string.Format(new FormatCustomer(), format, customer);
            return resultCustomer;
        }
    }
}
