namespace Stocks.Domain.Helpers.Stocks
{
    public class ProductParams : DefaultPaginationParams
    {
        public string Code { get; set; }
        public string Project { get; set; } = "all";
        public string SearchTerm { get; set; }
        public short HasStock { get; set; }
        public string Type { get; set; }
        public short status { get; set; }
        public string supplier { get; set; }
    }
}
