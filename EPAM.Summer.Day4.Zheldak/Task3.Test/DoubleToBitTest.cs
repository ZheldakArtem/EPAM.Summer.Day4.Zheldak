using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task3;

namespace Task3.Test
{
    public class DoubleToBitTests
    {

        [TestCase(34.8, ExpectedResult = "0100000001000001011001100110011001100110011001100110011001100110")]
        [TestCase(100.25,ExpectedResult = "0100000001011001000100000000000000000000000000000000000000000000")]
        [TestCase(-343545.1123546, ExpectedResult= "1100000100010100111101111110010001110011001100110011001100110011")]
        public string ConvertDoubleToStringOfBits_Test(double value)
        {
            return value.ConvertDoubleToStringOfBits();
        }
    }
}
