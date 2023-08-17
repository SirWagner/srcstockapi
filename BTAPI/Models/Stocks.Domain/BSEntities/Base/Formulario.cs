using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stocks.Domain.BSEntities.Base
{
    public class Formulario: INetcoreBasic
    {
        public int Id { get; set; }

        [JsonProperty("document")]
        [StringLength(5)]
        public string Documento { get; set; }

        [StringLength(20)]
        [JsonProperty("type")]
        public string Tipo { get; set; }

        [StringLength(20)]
        [JsonProperty("value")]
        public string Valor { get; set; }

        [JsonProperty("description")]
        public string Descricao { get; set; }

        [JsonProperty("required")]
        public bool Obrigatorio { get; set; }        

        [JsonProperty("Document")]
        [ForeignKey("Documento")]
        public TipoDocumento _Documento { get; set; }

        

    }
}
