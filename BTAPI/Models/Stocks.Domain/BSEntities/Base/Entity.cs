using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities.Base
{
    public class Entity 
    {
        [Key]
        [StringLength(10)]
        [JsonProperty("code")]
        public string Codigo { get; set; }

        [StringLength(80)]
        [JsonProperty("name")]
        public string Nome { get; set; }
    }
}
