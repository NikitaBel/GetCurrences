using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetCurrencies.Models
{
    public class Currency
    {
        public string ID { get; set; }

        public string NumCode { get; set; }

        public string CharCode { get; set; }

        public string Nominal { get; set; }

        public string Name { get; set;}

        public double Value { get; set; }

        public double Previous { get; set; }
    }
}
