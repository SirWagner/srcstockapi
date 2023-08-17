using Newtonsoft.Json;
using System;
using System.Data;

namespace Stocks.Domain.Helpers.Stocks
{
    public class EntityBalance
    {
        [JsonProperty("employee_id")]
        public string EntityId { get; set; }
        [JsonProperty("employee_name")]
        public string EntityName { get; set; }
        [JsonProperty("business_area_id")]
        public string BusinessAreaId { get; set; }
        [JsonProperty("business_area_description")]
        public string BusinessAreaDescription { get; set; }
        [JsonProperty("product_id")]
        public string ProductId { get; set; }
        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }
        [JsonProperty("balance")]
        public float PendingQtdItems { get; set; }
        //[JsonProperty("LastModifiedOn")]
        public DateTime LastModifiedOn { get; set; }
        
    }
}
