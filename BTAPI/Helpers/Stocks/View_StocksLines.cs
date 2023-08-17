using Stocks.Domain.BSEntities.Base;
using Stocks.Domain.BSEntities.Inventory;
using Newtonsoft.Json;
using System;

namespace Stocks.Data.Helper2
{
    public class View_StocksLines
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("date")]
        public DateTime Data { get; set; }
        
        [JsonProperty("description")]
        public string Descricao { get; set; }

        [JsonProperty("Unity")]
        public Unidades _Unidade { get; set; }

        [JsonProperty("Product")]
        public Artigo _Artigo { get; set; }

        [JsonProperty("factor")]
        public double FactorConversao { get; set; }

        [JsonProperty("in_out")]
        public char? EntradaSaida { get; set; }

        [JsonProperty("Branch")]
        public Armazem _Filial { get; set; }

        [JsonProperty("location")]
        public string Localizacao { get; set; }

        [JsonProperty("BusinessArea")]
        public AreaNegocio _AreaNegocio { get; set; }

        [JsonProperty("Project")]
        public Projeto _Projeto { get; set; }

        [JsonProperty("StatusDescription")]
        public string DescricaoEstado { get; set; }

        [JsonProperty("quantity")]
        public double Quantidade { get; set; }

        [JsonProperty("repair_type")]
        public short? TipoReparacao { get; set; }

        [JsonProperty("repair_quantity")] //eg. 2 holes.
        public short? QuantidadeReparacao { get; set; }

        [JsonProperty("created")]
        public DateTime? DataCriacao { get; set; }

        [JsonProperty("lastUpdate")]
        public DateTime? DataUltimaActualizacao { get; set; }

        [JsonProperty("createdBy")]
        public string Utilizador { get; set; }

        #region Dados Cabeçalho
        [JsonProperty("Document")]
        public CabecInterno _CabecInterno { get; set; }

        [JsonProperty("DocumentType")]
        public TipoDocumento _TipoDoc { get; set; }

        [JsonProperty("Entity")]
        public Funcionario _Entidade { get; set; }

        #endregion
    }
}
