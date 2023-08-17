using Newtonsoft.Json;

namespace Stocks.Domain.Helpers.Entity
{
    public class EntityParams : DefaultPaginationParams
    {
        [JsonProperty("type")]
        public char Type { get; set; } = 'U';
    }
}
