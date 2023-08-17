using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities.Base
{
    public class Filial 
    {
        [StringLength(38)]
        [JsonProperty("code")]
        [Key]
        public string Codigo { get; set; }

        [StringLength(50)]
        [JsonProperty("description")]
        public string Descricao { get; set; }

        [JsonProperty("isDefault")]
        public bool PorDefeito { get; set; } = false;

        [Required]
        [StringLength(50)]
        [JsonProperty("address1")]
        public string Morada1 { get; set; }

        [JsonProperty("address2")]
        [StringLength(50)]
        public string Morada2 { get; set; }

        [JsonProperty("city")]
        [StringLength(30)]
        public string Cidade { get; set; }

        [JsonProperty("state")]
        [StringLength(30)]
        public string Provincia { get; set; }

        [JsonProperty("country")]
        [StringLength(30)]
        public string Pais { get; set; }

        [JsonProperty("createdBy")]
        public string Utilizador { get; set; }

        //[JsonProperty("Warehouses")]
        //public Collection<Armazem> listaArmazens { get; set; }
    }
}
