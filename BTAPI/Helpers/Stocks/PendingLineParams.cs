using System.Collections.Generic;

namespace Stocks.Domain.Helpers.Stocks
{
    public class PendingLineParams : DefaultPaginationParams
    {
        public string DocType { get; set; } = "*";
        public string Entity { get; set; } = "*";
        public List<short?> ProductStatuses { get; set; } = new List<short?> { 6 };
    }
}
