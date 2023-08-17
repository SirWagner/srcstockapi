using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Core.DTOs.Stock
{
    public class DocumentToCreate
    {

            [JsonProperty("from_warehouse ")]
            public string ArmazemOrigem { get; set; }


            [JsonProperty("from_location")]
            public string LocalizacaoOrigem { get; set; }


            [JsonProperty("business_area_id")]
            public string AreaNegocio { get; set; }

            [JsonProperty("project_id")]
            public string Projecto { get; set; }


            [JsonProperty("document_type_id")]
            public string Tipodoc { get; set; }

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
            [JsonProperty("entity_type")]
            public string TipoEntidade { get; set; } = "F";

        [JsonProperty("entity_id")]
            public string Entidade { get; set; }

            [JsonProperty("entity_name")]
            public string Nome { get; set; }

            #endregion

            #region Extras
            [JsonIgnore]
            public string Resumo { get; set; }

            [JsonProperty("notes")]
            public string Notas { get; set; }

            [JsonProperty("attachement")]
            public string Anexo { get; set; }

            #endregion

            #region Dados Criacao
            [JsonProperty("created_on")]
            public DateTime? DataCriacao { get; set; } = DateTime.Now;

            [JsonProperty("last_modified_on")]
            public DateTime? DataUltimaActualizacao { get; set; } = DateTime.Now;

            [JsonProperty("user")]
            public string Utilizador { get; set; }
            #endregion
        }
    }