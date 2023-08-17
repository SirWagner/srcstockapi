namespace Stocks.Core.DTOs
{
    public class Unit
    {
        public string Base { get; set; }
        public string Sale { get; set; }
        public string Purchase { get; set; }
        public UnitItems Items { get; set; }
    }

    public class UnitItems
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Conversion { get; set; }
    }
}