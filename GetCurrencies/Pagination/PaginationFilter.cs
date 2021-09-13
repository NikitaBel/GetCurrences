using GetCurrencies.API;
using GetCurrencies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetCurrencies.Pagination
{
    public class PaginationFilter
    {
        public int PageNumber { get; set; }
        public int PageSize = 10;

        public int Sign { get; set; }
        public PaginationFilter()
        {
            this.PageNumber = 1;
            this.PageSize = 10;
        }
        public PaginationFilter(int pageNumber,int sign)
        {
            if (sign== -1)
            {
                this.PageNumber = 2;                
            }
            else
            {
                this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            }
                       
            this.Sign = sign;
        }

        public PagedResponse ApplyFilter(IEnumerable<Currency> currencies)
        {
            var list = currencies.Skip((PageNumber - 1) * PageSize).Take(PageSize);

            return new PagedResponse(list, PageNumber, PageSize, this.Sign);
        }

    }
}
