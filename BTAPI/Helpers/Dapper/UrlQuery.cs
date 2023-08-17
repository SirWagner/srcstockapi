namespace Stocks.Domain.Helpers.Dapper
{
    public class UrlQuery
    {

        private const int maxPageSize = 50;
        private int _pageSize = 15;

        public int? page { get; set; }

        public string sort_field { get; set; }

        public string sort_order { get; set; }

        public int rows_per_page
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value < maxPageSize) ? value : maxPageSize;
            }
        }
    }
}
