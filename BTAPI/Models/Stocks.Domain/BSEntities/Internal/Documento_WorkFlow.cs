using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stocks.Domain.BSEntities.Internal
{
    public class Documento_WorkFlow
    {
        [JsonProperty("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(20)]
        [JsonProperty("WorkFlow")]
        public string WorkFlow { get; set; }

        [StringLength(50)]
        [JsonProperty("description")]
        public string Descricao { get; set; }

    
        [StringLength(5)]
        [JsonProperty("documentTypeOrigin")]
        public string TipoDocumentoOrigem { get; set; }
                
        [StringLength(5)]
        [JsonProperty("documentTypeDestination")]
        public string TipoDocumentoDestino { get; set; }

        [StringLength(20)]
        public string EstadoDocumentoDestino { get; set; }

        [JsonProperty("isAutoCreate")]
        public bool CriacaoAutomatica { get; set; }

        [JsonIgnore]
        [ForeignKey("TipoDocumentoOrigem")]
        public TipoDocumento _TipoDocumentoOrigem { get; set; }
    }
}
