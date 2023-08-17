using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Base
{
    public interface ICabec 
    {
        #region Dados Gerais
        DateTime Data { get; set; }

        [StringLength(5)]
        string Tipodoc { get; set; }

        [StringLength(5)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        long NumDoc { get; set; }

        [StringLength(20)]
        string NrDocExterno { get; set; }

        [StringLength(10)]
        string Serie { get; set; }
        #endregion

        #region Dados Entidade
        [StringLength(5)]
        string TipoEntidade { get; set; }

        [StringLength(20)]
        string Entidade { get; set; }

        [StringLength(50)]
        string Nome { get; set; }
        #endregion

        #region Extras
        [StringLength(50)]
        string Resumo { get; set; }

        string Notas { get; set; }

        [StringLength(50)]
        string Anexo { get; set; }
        #endregion

    }
}
