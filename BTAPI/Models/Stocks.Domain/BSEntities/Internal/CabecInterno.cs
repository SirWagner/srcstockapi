using Stocks.Domain.BSEntities.Base;
using Stocks.Domain.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Inventory
{
    public class CabecInterno 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public long IdMigracao { get; set; }

        [StringLength(10)]
        [JsonProperty("from_warehouse ")]
        public string ArmazemOrigem { get; set; }

        [JsonProperty("parent_document_origin_Id")]
        public Guid? IdDocumentoOrigem { get; set; }

        [StringLength(10)]
        [JsonProperty("from_location")]
        public string LocalizacaoOrigem { get; set; }

        [StringLength(20)]
        [JsonProperty("business_area_id")]
        public string AreaNegocio { get; set; }

        [ForeignKey("AreaNegocio")]
        [JsonProperty("business_area")]
        public AreaNegocio _AreaNegocio { get; set; }

        [StringLength(15)]
        [JsonProperty("project_id")]
        public string Projecto { get; set; }

        /// <summary>
        /// Header doc status that tell if the doc 
        /// </summary>
        public StockStatus Status { get; set; }

        [Required]
        [JsonProperty("details")]
        public Collection<LinhaInterno> Linhas { get; set; }

        [Required]
        [StringLength(5)]
        [JsonProperty("document_type_id")]
        public string Tipodoc { get; set; }

        [JsonProperty("document_type")]
        [ForeignKey("Tipodoc")]
        public TipoDocumento _TipoDoc { get; set; }

        #region Dados Gerais
        [JsonProperty("date")]
        public DateTime Data { get; set; }

        [JsonProperty("doc_number")]
        public long NumDoc { get; set; }

        [JsonProperty("reference_doc")]
        public string NrDocExterno { get; set; }

        public string Serie { get; set; } = DateTime.Now.Year.ToString();
        #endregion

        #region Dados Entidade
        [Required]
        [JsonProperty("entity_type")]
        public string TipoEntidade { get; set; }

        [StringLength(10)]
        [JsonProperty("entity_id")]
        public string Entidade { get; set; }

        [JsonProperty("entity_name")]
        public string Nome { get; set; }

        [ForeignKey("Entidade")]
        [JsonProperty("entity")]
        public Funcionario _Entidade { get; set; }

        [JsonProperty("supplier_id")]
        public string IdFornecedor { get; set; } = null;

        [ForeignKey("IdFornecedor")]
        [StringLength(10)]
        [JsonProperty("supplier")]
        public Fornecedor Fornecedor { get; set; }

        #endregion

        #region Extras
        [JsonIgnore]
        public string Resumo { get; set; }

        [JsonProperty("notes")]
        public string Notas { get; set; }

        [JsonProperty("attachement")]
        public string Anexo { get; set; }

        [JsonProperty("attachement_path")]
        public string PathAnexo { get; set; }

        #endregion

        #region Dados Criacao
        //[JsonProperty("created_on")]
        //public DateTime? DataCriacao { get; set; } = DateTime.Now;

        //[JsonProperty("last_modified_on")]
        //public DateTime? DataUltimaActualizacao { get; set; } = DateTime.Now;

        [JsonProperty("user")]
        public string Utilizador { get; set; }
         #endregion
    }
}
