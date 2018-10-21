using Newtonsoft.Json;

namespace Modelo.ApiCore.Dapper.Infra.CrossCutting.AspNetFilters.Models
{
    public class Item
    {
        public Item();
        public Item(string key = null, string value = null);

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
