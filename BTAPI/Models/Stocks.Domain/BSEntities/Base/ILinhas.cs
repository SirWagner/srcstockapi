using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities.Base
{
    public class ILinha: INetcoreBasic
    {
        #region Dados Gerais
        [StringLength(50)]
        string Descricao { get; set; }

        string Notas { get; set; }

        string Data { get; set; }
        #endregion

        #region Dados Artigo
        [StringLength(48)]
        string Artigo { get; set; }

        double FactorConversao { get; set; }

        string Armazem { get; set; }

        string Localizacao { get; set; }

        #endregion

        #region classificadores
        [StringLength(15)]
        string AreaNegocio { get; set; }

        [StringLength(15)]
        string Projecto { get; set; }
        #endregion
    }
}
