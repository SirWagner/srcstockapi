namespace Stocks.Core.DTOs
{
    public class Warehouse
    {
        public Guid Id { get; set; }    
        public string Default { get; set; }
        public decimal TotalStock { get; set; }
        public WarehouseItem Items { get; set; }   
    }

    public class WarehouseItem
    {
        public Guid Id { get; set; }
        public string Wharehouse { get; set; }
        public decimal Stock { get; set; }
    }
}