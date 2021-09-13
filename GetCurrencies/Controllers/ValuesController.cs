using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetCurrencies.Models;
using static GetCurrencies.API.CurrencyApi;
using GetCurrencies.Pagination;

namespace GetCurrencies.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("currencies/{pageNumber}&{sign}", Name = "GetCurrencies")]
        public async Task<ActionResult<IEnumerable<Currency>>> GetCurrenciesAsync(int pageNumber, int sign=1)
        {
            PaginationFilter Filter = new PaginationFilter(pageNumber,  sign);
            
            var list = await RequestCurrrency();
            var result = Filter.ApplyFilter(list.Valute.Values);
            return Ok(result);
        }
        
        [HttpGet("currency/{id}", Name = "GetCurrency")]
        public async Task<ActionResult<Currency>> GetCurrency(string id)
        {
            var list = await RequestCurrrency();
            return Ok(list.Valute[id]);
        }


        
    }
}
