using System;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities
{
    public class INetcoreBasic
    {
        DateTime? DataCriacao { get; set; }

        DateTime? DataUltimaActualizacao { get; set; }

        [StringLength(100)]
        string Utilizador { get; set; }
    }
}
