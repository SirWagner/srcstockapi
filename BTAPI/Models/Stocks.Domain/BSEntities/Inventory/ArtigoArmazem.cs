using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Inventory
{
    public class ArtigoArmazem
    {
        [StringLength(48)]
        [Key]
        [JsonProperty("product")]
        public string Artigo { get; set; }

        [JsonProperty("default")]
        [StringLength(12)]
        public string Armazem_Defeito { get; set; }

        [JsonProperty("totalStock")]
        public float StkActual { get; set; }

        [JsonIgnore]
        [Display(Name = "Stock Minimo")]
        public double StkMinimo { get; set; }

        [JsonIgnore]
        [Display(Name = "Stock Maximo")]
        public double StkMaximo { get; set; }

        [JsonIgnore]
        [Display(Name = "Stock Reposição")]
        public double StkReposicao { get; set; }

        [JsonProperty("items")]
        public ICollection<Linhas_ArtigoArmazem> Linhas_ArtigoArmazem { get; set; }

        [ForeignKey("Artigo")]
        [JsonIgnore]
        public Artigo _Artigo { get; set; }

        [ForeignKey("Armazem_Defeito")]
        [JsonIgnore]
        public Armazem _Armazem_Defeito { get; set; }
    }

    public class Linhas_ArtigoArmazem
    {
        public int Id { get; set; }
        [StringLength(48)]
        [Display(Name = "Artigo")]
        [JsonProperty("product")]
        public string Artigo { get; set; }

        [StringLength(12)]
        [Display(Name = "Armazem")]
        [JsonProperty("warehouse")]
        public string Armazem { get; set; }

        [JsonProperty("stock")]
        public double StkActual { get; set; }

        [ForeignKey("Artigo")]
        [JsonProperty("Product")]
        public Artigo _Artigo { get; set; }

        [ForeignKey("Armazem")]
        [JsonProperty("Warehouse")]
        public Armazem _Armazem { get; set; }
    }
}