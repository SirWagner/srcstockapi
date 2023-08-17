using Stocks.Domain.BSEntities.Base;
using Stocks.Domain.BSEntities.Inventory;
using Newtonsoft.Json;
using System;

namespace Stocks.Domain.Helpers.Stocks
{
    public class PendingLine
    {
        [JsonProperty("product_id")]
        public string IdProduct { get; set; }

        [JsonProperty("unit_id")]
        public string IdUnidade { get; set; }

        [JsonProperty("status_id")]
        public short? IdEstado { get; set; }

        [JsonProperty("business_area")]
        public string AreaNegocio { get; set; }

        [JsonProperty("businessAreaDescription")]
        public string DescricaoAreaNegocio { get; set; }

        [JsonProperty("description")]
        public string Descricao { get; set; }

        [JsonProperty("doc_number")]
        public long NumDoc { get; set; }

        [JsonProperty("entity")]
        public string Entidade { get; set; }

        [JsonProperty("entityName")]
        public string NomeEntidade { get; set; }

        [JsonProperty("delivery_notes")]
        public string NotasDevolucao { get; set; }

        [JsonProperty("warehouse_id")]
        public string Armazem { get; set; }

        [JsonProperty("location")]
        public string Localizacao { get; set; }

        [JsonProperty("validation_notes")]
        public string NotasValidacao { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("pending_qtd")]
        public double QuantidadePendente { get; set; }

        [JsonProperty("repair_type")]
        public short? TipoReparacao { get; set; }

        [JsonProperty("repair_quantity")] //eg. 2 holes.
        public short? QuantidadeReparacao { get; set; }

        [JsonProperty("quantity")]
        public double Quantidade { get; set; }

        [JsonProperty("project")]
        public Projeto Projecto { get; set; }

        [JsonProperty("header_id")]
        public Guid IdCabec { get; set; }

        [JsonProperty("status")]
        public EstadoArtigo Estado { get; set; }

        [JsonProperty("next_status")]
        public EstadoArtigo ProximoEstado { get; set; }
        public string TipoDoc { get; set; }
    }
}