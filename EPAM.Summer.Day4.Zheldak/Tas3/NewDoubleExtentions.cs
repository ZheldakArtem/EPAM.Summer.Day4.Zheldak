using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tas3
{
    public static class NewDoubleExtentions
    {
        
        /// <param name="value">The number to convert.</param>
        /// <returns>String with number in IEEE 754 binary format.</returns>
        public static string IEEE754(this double value)
        {
            var iee754 = new StringBuilder();
            var bytesInnerInt = BitConverter.GetBytes(value);

            for (int i = sizeof(byte) - 1; i >= 0; i--)
            {
                for (int j = 0; j < sizeof(byte) - 1; j++)
                {
                    iee754.Append((bytesInnerInt[i] & (sizeof(byte) * (sizeof(byte) + sizeof(byte)) >> j)) > 0 ? "1" : "0");
                }
            }

            return iee754.ToString();
        }
    }
}
