using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Helpers.Product
{
    public class View_EntityStock
    {
        [JsonProperty("Product")]
        public Artigo _Artigo { get; set; }
    }
}
