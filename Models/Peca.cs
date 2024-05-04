using Newtonsoft.Json;

namespace OrcamentoVinil.Models
{
    public class Peca
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }
    }
}
