using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Helpers.Stocks
{
    public class PrimaveraStock
    {
        public string Product { get; set; }
        public string ProductDescription { get; set; }
        public string Warehouse { get; set; }
        public string WarehouseDescription { get; set; }
        public double Stock { get; set; }
    }
}
