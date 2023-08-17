using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Inventory
{
    /// <summary>
    /// Tabela de registo da forma como os valores lançados nos documentos são convertidos de uma unidade para outra.
    /// </summary>
    public class UnidadesConversao
    {
        public int Id { get; set; }
        [StringLength(5)]
        [ForeignKey("UnidadeOrigem")]
        public string UnidadeOrigem { get; set; }

        [StringLength(5)]
        [ForeignKey("UnidadeDestino")]
        public string UnidadeDestino { get; set; }

        [StringLength(512)]
        public string Formula { get; set; }

        public float FactorConversao { get; set; }

        public bool UtilzaFormula { get; set; }
    }
}
