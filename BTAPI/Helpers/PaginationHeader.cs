namespace Stocks.Domain.Helpers
{
    public class PaginationHeader
    {
        public int CurrentPage { get; set; }
        public int Size { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }

        public PaginationHeader(int currentPage, int size, int totalRecords, int totalPages)
        {
            CurrentPage = currentPage;
            Size = size;
            TotalRecords = totalRecords;
            TotalPages = totalPages;
        }
    }
}
