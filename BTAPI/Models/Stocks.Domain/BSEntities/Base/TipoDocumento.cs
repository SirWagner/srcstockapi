using Stocks.Domain.BSEntities.Internal;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities.Base
{
    public class TipoDocumento { 
        [Key]
        [StringLength(5)]
        [JsonProperty("code")]
        public string Documento { get; set; }

        [JsonProperty("order")]
        public int ordem { get; set; }

        [JsonProperty("isVisibleDashboard")]
        public bool visivelPaginaInicial { get; set; }

        [StringLength(50)]
        [JsonProperty("description")]
        public string Descricao { get; set; }

        [StringLength(50)]
        [JsonProperty("friendlyUserName")]
        public string NomeAmigavelUtilizador { get; set; }

        [StringLength(128)]
        [JsonProperty("generatedAction")]
        public string AccaoGerada { get; set; }

        [StringLength(20)]
        [JsonProperty("classifier")]
        public string Classificacao { get; set; }

        [StringLength(20)]
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [StringLength(5)]
        [JsonProperty("type")]
        public string Tipo { get; set; }

        [StringLength(5)]
        [JsonProperty("typeArticle")]
        public string TipoArtigo { get; set; }

        [StringLength(10)]
        [JsonProperty("module")]
        public string Modulo { get; set; }

        [JsonProperty("isFilterTypeProduct")]
        public bool TemFiltroTipoArtigo { get; set; }

        [JsonProperty("isSelectedProduct")]
        public bool TemSelecaoArtigo { get; set; }

        [JsonProperty("canAddProduct")]
        public bool PermiteAdicaoArtigosNovos { get; set; }

        [JsonProperty("returnProductEntity")]
        public bool DaArtigosEntidade { get; set; }

        [JsonProperty("isStockMoviment")]
        public bool MovimentaStock { get; set; }

        [JsonProperty("isStockMovimentEntity")]
        public bool MovimentaStockEntidade { get; set; }

        [JsonProperty("filterProductStock")]
        public bool FiltraArtigoStock { get; set; }

        //[JsonProperty("Form")]
        //public Formulario Formulario { get; set; }

        //[JsonProperty("WorkFlows")]
        //public Collection<Documento_WorkFlow> Documento_WorkFlows { get; set; }
    }
}
