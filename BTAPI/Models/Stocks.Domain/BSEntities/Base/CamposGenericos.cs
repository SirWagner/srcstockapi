using Newtonsoft.Json;
using System;

namespace Stocks.Domain.BSEntities.Base
{
    public abstract class GenericFields
    {
        [JsonProperty("createdAt")]
        public DateTime? DataCriacao { get; set; } = DateTime.Now;
        [JsonProperty("lastModifiedOn")]
        public DateTime? DataUltimaActualizacao { get; set; } = DateTime.Now;
        /// <summary>
        /// Tell wathever a record is innactive or not
        /// </summary>
        [JsonProperty("inactive")]
        public bool? Inactive { get; set; } = false;
    }
}
