using System.Collections.Generic;

namespace Stocks.Domain.Helpers.Dapper
{
    public class Pagination<T>
    {
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }
        public long? TotalRecords { get; set; }
        public int? TotalPages { get; set; } // => (int?)Math.Ceiling((long)TotalRecords / (double)PageSize);
        public IEnumerable<T> Records { get; set; }

        public bool HasPrevious
        {
            get { return CurrentPage > 1; }
        }

        public bool HasNext
        {
            get { return CurrentPage < TotalPages; }
        }
    }
}
