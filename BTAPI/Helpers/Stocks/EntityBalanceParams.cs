using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Helpers.Stocks
{
    //TODO: Make it more readeable
    public class EntityBalanceParams : DefaultPaginationParams
    {
        public string Module { get; set; } = "*";
        [JsonProperty("product_type")]
        public string ProductType { get; set; } = "*";
        [JsonProperty("productId")]
        public string ProductId { get; set; } = "*";
         [JsonProperty("warehouseId")]
        public string Warehouse { get; set; } = "*";
        [JsonProperty("entity")]
        public string Entity { get; set; } = "*";
        [JsonProperty("has_balance")]
        public bool HasBalance { get; set; } = true;
    }
}
