using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    class FormatCustomer : IFormatProvider, ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            Customer customer = (Customer)arg;
            StringBuilder str = new StringBuilder();

            str.Append("Customer record:");
           
                if (format.Contains("N"))
                {
                    str.Append(" " + customer.Name);
                }

                if (format.Contains("R"))
                {
                    str.Append($"{customer.Revenue:C}");
                }

                if (format.Contains("C"))
                {
                    str.Append(" " + customer.ContactPhone);
                }

                return str.ToString();
            }
      

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            return null;
        }

    }
}
