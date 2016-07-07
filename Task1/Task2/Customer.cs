using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Customer
    {
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }

        public Customer(string name, string contactPhone, decimal revenue)
        {
            Name = name;
            ContactPhone = contactPhone;
            Revenue = revenue;  
        }

        public string ToString(string param)
        {
            if (param == null)
                throw new ArgumentNullException();
            FormatCustomer formatProvider = new FormatCustomer();
            param = $"{{0:{param}}}";
            return string.Format(formatProvider, param, this);
        }
        public override string ToString()
        {
            return ToString("NCR");
        }
    }
}
