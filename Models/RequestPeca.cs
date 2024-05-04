using Newtonsoft.Json;

namespace OrcamentoVinil.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, Title = "")]
    public class RequestPeca
    {
        [JsonProperty("descricao")]
        public string Descricao { get; set; }
    }
}
