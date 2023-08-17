
using Stocks.Domain.BSEntities.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Base
{
    public class Armazem 
    {
        [Key]
        [StringLength(12)]
        [JsonProperty("code")]
        public string Codigo { get; set; }

        [StringLength(50)]
        [JsonProperty("description")]
        public string Descricao { get; set; }

        [StringLength(38)]        
        [JsonProperty("branch")]
        public string Filial { get; set; }

        [ForeignKey("Filial")]
        [JsonIgnore]
        public Filial _Filial { get; set; }

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

        [JsonProperty("localizations")]
        public IEnumerable<ArmazemLocalizacoes> ArmazemLocalizacoes { get; set; }
    }
}
