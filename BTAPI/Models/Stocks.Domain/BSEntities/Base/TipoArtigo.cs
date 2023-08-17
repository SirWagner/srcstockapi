using Stocks.Domain.BSEntities.Inventory;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities.Base
{
    public class TipoArtigo 
    {
        [Key]
        [StringLength(10)]
        [JsonProperty("code")]
        public string Codigo { get; set; }

        [StringLength(50)]
        [JsonProperty("description")]
        public string Descricao { get; set; }

        [JsonProperty("Status")]
        public Collection<EstadoArtigo> EstadoArtigos { get; set; }
    }
}
