using Stocks.Domain.BSEntities.Base;

namespace Stocks.Domain.BSEntities
{
    public class Role 
    {
        public short Id { get; set; }
        public string UniqueIdentifier{ get; set; }
        public string Description { get; set; }
    }
}
