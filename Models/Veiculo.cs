using Newtonsoft.Json;

namespace OrcamentoVinil.Models
{
    public class Veiculo
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("marca")]
        public string Marca { get; set; }

        [JsonProperty("modelo")]
        public string Modelo { get; set; }

        [JsonProperty("ano")]
        public string Ano { get; set; }

        [JsonProperty("pecasVeiculo")]
        public List<PecaVeiculo> PecasVeiculo { get; set; }
    }

    public class PecaVeiculo
    {
        [JsonProperty("idPeca")]
        public int? IdPeca { get; set; }

        [JsonProperty("descricaoPeca")]
        public string DescricaoPeca { get; set; }

        [JsonProperty("tamanhoM2")]
        public decimal TamanhoM2 { get; set; }

        [JsonProperty("tamanhoML")]
        public decimal TamanhoML { get; set; }
    }
}
