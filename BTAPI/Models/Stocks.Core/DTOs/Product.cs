namespace Stocks.Core.DTOs
{
    public class Product
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }
        public Warehouse Warehouse { get; set; }
        public ProductType Type { get; set; }
        public Unit Unit { get; set; }
    }
}
