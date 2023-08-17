using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.HR
{
    public class FuncionarioAreaNegocio
    {
        public int id { get; set; }

        [JsonProperty("employee")]
        [StringLength(10)]
        public string Funcionario { get; set; }

        [JsonProperty("businessArea")]
        [StringLength(20)]
        public string AreaNegocio { get; set; }

        //[Required]
        //[JsonProperty("fiscalYear")]
        //public short AnoFiscal { get; set; }

        [JsonProperty("isSupervisor")]
        public bool Supervisor { get; set; }

        [JsonProperty("isDirector")]
        public bool Director { get; set; }

        [JsonProperty("isPrincipal")]
        public bool Principal { get; set; }

        [ForeignKey("Funcionario")]
        [JsonIgnore]
        public Funcionario _Funcionario { get; set; }

        [ForeignKey("AreaNegocio")]
        [JsonIgnore]
        public AreaNegocio _AreaNegocio { get; set; }
    }
}
