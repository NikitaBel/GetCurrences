using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetCurrencies.Models;

namespace GetCurrencies.API
{
    public class PagedResponse
    {
        public PagedResponse(IEnumerable<Currency> currencies, int pageNumber, int pageSize, int sign)
        {
            this.Currencies = currencies.ToList();
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalRecords = currencies.Count();
            this.TotalPages = TotalRecords / pageSize;

            if (sign == 1)
            {
                this.NextPage = PageNumber != TotalPages ? PageNumber + 1 : TotalPages;
                this.PreviousPage = PageNumber != 1 ?  PageNumber - 1 : 1;
            }
            else if (sign == -1)
            {
                this.NextPage = 2;
                this.PreviousPage = 0;
            }            
            
        }


        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public int NextPage { get; set; }
        public int PreviousPage { get; set; }

        public List<Currency> Currencies { get; set; }
    }
}
