using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities.Base
{
    public class Unidades
    {
        [JsonProperty("code")]
        [StringLength(5)]
        [Key]
        public string Codigo { get; set; }

        [JsonProperty("description")]
        [StringLength(50)]
        public string Descricao { get; set; }

        [JsonProperty("rounding")]
        public int Arredondamento { get; set; }
    }
}
