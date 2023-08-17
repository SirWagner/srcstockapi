namespace Stocks.Domain.Helpers
{
    public class DefaultPaginationParams
    {
        private int MaxPageSize { get; set; } = 200;
        public int Page { get; set; } = 1;
        public string SearchTerm { get; set; }
        private int pageSize { get; set; } = 200;
        public int Size
        {
            get { return pageSize; }
            set {pageSize = (value > MaxPageSize) ? MaxPageSize : value ; }
        }
    }
}
