using Stocks.Domain.BSEntities.Base;
using Stocks.Domain.BSEntities.Inventory;

namespace Stocks.Domain.Helpers.Product
{
    public class CanisterAllocatedInProject
    {
        public Artigo Product { get; set; }
        public EstadoArtigo Status { get; set; }
        public Fornecedor Supplier { get; set; }
        public Projeto Project { get; set; }
        public bool StatusInProject { get; set; }
    }
}
