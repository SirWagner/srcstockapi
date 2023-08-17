using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Core.DTOs.Stock
{
    public class GenericHeaderProperties
    {
        #region Dados Gerais
        DateTime Data { get; set; }

        string Tipodoc { get; set; }

        long NumDoc { get; set; }


        string NrDocExterno { get; set; }

        string Serie { get; set; }

        string TipoEntidade { get; set; }

        string Entidade { get; set; }


        string Nome { get; set; }
        #endregion

        #region Extras
        string Resumo { get; set; }

        string Notas { get; set; }


        string Anexo { get; set; }
        #endregion

    }
}
