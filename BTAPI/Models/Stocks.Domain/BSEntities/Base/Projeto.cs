using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities.Base
{
    public class Projeto 
    {
        [Key]
        [StringLength(15)]
        [JsonProperty("code")]
        public string Codigo { get; set; }

        [StringLength(128)]
        [JsonProperty("description")]
        public string Descricao { get; set; }

        [StringLength(5)]
        [JsonIgnore]
        public string TipoEntidade { get; set; }

        [StringLength(12)]
        [JsonIgnore]
        public string Entidade { get; set; }

        [StringLength(10)]
        [JsonIgnore]
        public string Estado { get; set; }

        [StringLength(5)]
        [JsonIgnore]
        public string TipoEntidadeResponsavel { get; set; }

        [StringLength(12)]
        [JsonIgnore]
        public string EntidadeResponsavel { get; set; }

        [JsonIgnore]
        public DateTime? DataConclusaoPrevista { get; set; }

        [JsonIgnore]
        public DateTime? PrevisaoInicio { get; set; }

        [StringLength(50)]
        [JsonIgnore]
        public string LocalExec { get; set; }

        [StringLength(10)]
        [JsonIgnore]
        public string TipoProjecto { get; set; }

        [StringLength(50)]
        [JsonIgnore]
        public string Referencia { get; set; }

        [JsonIgnore]
        public int Prioridade { get; set; }

        [JsonIgnore]
        public string Utilizador { get; set; }
    }
}
