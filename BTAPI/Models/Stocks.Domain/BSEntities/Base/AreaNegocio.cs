using Stocks.Domain.BSEntities.HR;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities.Base
{
    public class AreaNegocio 
    {
        [Key]
        [StringLength(20)]
        [JsonProperty("code")]
        public string codigo { get; set; }

        [StringLength(50)]
        [JsonProperty("description")]
        public string descricao { get; set; }

        [JsonProperty("year")]
        public short? Ano { get; set; }

        //[JsonProperty("fiscalYear")]
        //public short AnoFiscal { get; set; }

        [JsonProperty("Items")]
        public ICollection<FuncionarioAreaNegocio> FuncionarioAreaNegocio { get; set; }
    }
}
