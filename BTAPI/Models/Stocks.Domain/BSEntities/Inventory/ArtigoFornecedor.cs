using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stocks.Domain.BSEntities.Inventory
{
    public class ArtigoFornecedor
    {

        public int id { get; set; }

        [StringLength(48)]
        [JsonProperty("product_id")]
        public string Artigo { get; set; }

        [StringLength(50)]
        [JsonProperty("description")]
        public string Descricao { get; set; }

        [StringLength(5)]
        [JsonProperty("entity_type")]
        public string TipoEntidade { get; set; }

        [StringLength(10)]
        [JsonProperty("entity")]
        public string Entidade { get; set; }

        [JsonProperty("status")]
        public short? Estado { get; set; }

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

        [StringLength(30)]
        [JsonProperty("is_with_supplier")]
        public bool ComFornecedor { get; set; }

        [ForeignKey("Artigo")]
        [JsonProperty("Product")]
        public Artigo _Artigo { get; set; }

        [StringLength(10)]
        [JsonProperty("Entity")]
        [ForeignKey("Entidade")]
        public Fornecedor _Fornecedor { get; set; }
    }
}
