using Newtonsoft.Json;

namespace OrcamentoVinil.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, Title = "")]
    public class RequestMaterial
    {
        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("precoM2")]
        public decimal PrecoM2 { get; set; }

        [JsonProperty("precoML")]
        public decimal PrecoML { get; set; }
    }
}
