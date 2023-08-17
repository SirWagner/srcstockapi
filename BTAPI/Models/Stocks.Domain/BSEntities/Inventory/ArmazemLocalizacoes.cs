using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Inventory
{
    public class ArmazemLocalizacoes : INetcoreBasic
    {
        [Key]
        [StringLength(20)]
        [JsonProperty("code")]
        [Required]
        public string localizacao { get; set; }

        [StringLength(12)]
        [Required]
        [JsonProperty("warehouseId")]
        public string armazem { get; set; }

        [JsonProperty("warehouse")]
        [JsonIgnore]
        [ForeignKey("armazem")]
        public Armazem Armazem { get; set; }

        [StringLength(50)]
        [JsonProperty("description")]
        [Required]
        public string descricao { get; set; }

        [JsonProperty("active")]
        public bool? activa { get; set; } = true;

        [JsonProperty("anual")]
        public bool? manual { get; set; }

        [JsonIgnore]
        [StringLength(20)]
        public string nomeNivel { get; set; }

        [JsonIgnore]
        [JsonProperty("createdAt")]
        public DateTime? DataCriacao { get; set; } = DateTime.UtcNow;

        [JsonIgnore]
        [JsonProperty("lastUpdate")]
        public DateTime? DataUltimaActualizacao { get; set; }

        [JsonIgnore]
        [JsonProperty("createdBy")]
        public string Utilizador { get; set; }
    }
}
