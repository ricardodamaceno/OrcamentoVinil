using Newtonsoft.Json;

namespace OrcamentoVinil.Models
{
    public class Material
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("precoM2")]
        public decimal PrecoM2 { get; set; }

        [JsonProperty("precoML")]
        public decimal PrecoML { get; set; }
    }
}
