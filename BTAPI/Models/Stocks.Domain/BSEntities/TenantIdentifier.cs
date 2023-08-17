using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities
{
    public class TenantIdentifier 
    {
        [StringLength(38)]
        [JsonProperty("branch")]
        public string Filial { get; set; }

        [StringLength(12)]
        [JsonProperty("warehouse")]
        public string Armazem { get; set; }

        [StringLength(128)]
        [JsonProperty("location")]
        public string Localizacao { get; set; }

        [JsonIgnore]
        [ForeignKey("Armazem")]
        [JsonProperty("Warehouse")]
        public Armazem _Armazem { get; set; }

        [JsonIgnore]
        [ForeignKey("Filial")]
        [JsonProperty("Branch")]
        public Filial _Filial { get; set; }
    }
}
