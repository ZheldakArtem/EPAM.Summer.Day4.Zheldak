using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tas3
{
    public static class DoublуExtentions
    {

        private const int Mantissabit = 52;
        private const int Expbit = 11;
        /// <summary>
        /// The method converts the double value to binary value.
        /// </summary>
        /// <param name="doubleVal">input number</param>
        /// <returns>String binary number</returns>
        public static string ConvertDoubleToStringOfBits(this double doubleVal)
        {
            string result = string.Empty;

            if (doubleVal < 0)
            {
                result += "1";
            }
            else
            {
                result += "0";
            }

            string[] splitStr = doubleVal.ToString().Split(',');
            string wholeStr = IntToBin(int.Parse(splitStr[0]));
            string remainderBitStr = RemainderToBit(double.Parse("0," + splitStr[1]), Mantissabit - wholeStr.Length + 1);
            string expToBit = IntToBin(wholeStr.Length - 1 + 1023);

            for (int i = 0; i < expToBit.Length - Expbit; i++)
            {
                expToBit += "0";
            }

            result += expToBit + GetMantissa(wholeStr, remainderBitStr);
            return result;
        }

        private static string RemainderToBit(double remainder, int maxLength)
        {

            var str = new StringBuilder();
            if (remainder < 0 || remainder >= 1)
            {
                throw new ArgumentException();
            }

            if (remainder == 0)
            {
                for (int i = 0; i < maxLength - 1; i++)
                {
                    str.Append("0");
                }
                return str.ToString();
            }
            for (int i = 0; i < maxLength; i++)
            {
                remainder *= 2;
                if (remainder == 1)
                {
                    str.Append("1");
                    return str.ToString();
                }
                if (remainder > 1)
                {
                    str.Append("1");
                    remainder--;
                }
                else
                {
                    str.Append("0");
                }
            }

            return str.ToString();
        }
        private static string IntToBin(long number)
        {
            var stBuild = new StringBuilder();

            for (var i = sizeof(long) * 8 - 1; i >= 0; i--)
                stBuild.Append((number & ((long)1 << i)) != 0 ? '1' : '0');

            return stBuild.ToString().TrimStart('0');
        }
        private static string GetMantissa(string wholePart, string remainderPart)
        {
            var strBuild = new StringBuilder();
            char[] ch = wholePart.ToCharArray();
            for (int i = 1; i < ch.Length; i++)
            {
                strBuild.Append(ch[i]);
            }
            strBuild.AppendLine(remainderPart);

            for (var i = 1; i < Mantissabit - wholePart.Length - 1 - remainderPart.Length; i++)
            {
                strBuild.Append("0");
            }

            return strBuild.ToString();
        }
    }
}