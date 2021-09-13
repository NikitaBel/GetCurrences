using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetCurrencies.Models
{
    public class DailyCurrences
    {
        public DateTime Date { get; set; }

        public DateTime PreviousDate { get; set; }

        public string PreviousURL { get; set; }

        public DateTime Timestamp { get; set; }

        public Dictionary<string,Currency> Valute { get; set; }
        
    }
}
