using GetCurrencies.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetCurrencies.API
{
    public static class CurrencyApi
    {
        public static async Task<DailyCurrences> RequestCurrrency()
        {
            var client = new System.Net.Http.HttpClient();
            var response = await client.GetAsync("https://www.cbr-xml-daily.ru/daily_json.js");
            string result = await response.Content.ReadAsStringAsync();
            DailyCurrences list = JsonConvert.DeserializeObject<DailyCurrences>(result);
            return list;
        }

        public static async Task<Dictionary<string,Currency>> GetCurrencyCodes()
        {
            var list = await RequestCurrrency();
            //var result = list.Valute.Values.Select(c => c.Name);
            return list.Valute;
        }
    }
}
