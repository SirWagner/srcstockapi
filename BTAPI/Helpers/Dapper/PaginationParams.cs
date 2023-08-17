namespace Stocks.Domain.Helpers.Dapper
{
    public class PaginationParams
    {
        public int? PageNumber { get; set; } = 15;
        public int? PageSize { get; set; } = 25;
        public string SearchTerm { get; set; } = "*";
        //TODO: Fix it with inheritance
        public string ProductType { get; set; } = "*";
        public string SortOrder { get; set; } = "DESC";
        public string SortField { get; set; } = "Id";
 
    }
}
