using Newtonsoft.Json;

namespace OrcamentoVinil.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, Title = "")]
    public class RequestVeiculo
    {
        [JsonProperty("marca")]
        public string Marca { get; set; }

        [JsonProperty("modelo")]
        public string Modelo { get; set; }

        [JsonProperty("ano")]
        public string Ano { get; set; }

        [JsonProperty("pecaVeiculoRequest")]
        public List<RequestPecaVeiculo> PecasVeiculo { get; set; }
    }

    public class RequestPecaVeiculo
	{
        [JsonIgnore]
        public bool Ativo { get; set; } = true;

        [JsonIgnore]
        public string? PecaDescricao { get; set; }

        [JsonProperty("pecaID")]
        public int PecaID { get; set; }

        [JsonProperty("tamanhoM2")]
        public int TamanhoM2 { get; set; }

        [JsonProperty("tamanhoML")]
        public int TamanhoML { get; set; }
    }
}
