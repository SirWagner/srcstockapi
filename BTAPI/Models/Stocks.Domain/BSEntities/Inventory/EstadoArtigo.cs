using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities.Inventory
{
    public class EstadoArtigo 
    {
        [Key]
        [JsonProperty("code")]
        public short Id { get; set; }

        [JsonProperty("description")]
        [StringLength(50)]
        public string Descricao { get; set; }

        [JsonProperty("productType")]
        [StringLength(10)]
        public string TipoArtigo { get; set; }

        [JsonIgnore]
        public TipoArtigo _TipoArtigo { get; set; }
    }
}
