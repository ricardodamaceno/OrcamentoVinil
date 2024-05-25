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

        [JsonProperty("pecaMaterials")]
        public List<PecaMaterial> PecaMateriais { get; set; }
    }

    public class PecaMaterial
    {
        [JsonProperty("idPeca")]
        public int? IdPeca { get; set; }

        [JsonProperty("descricaoPeca")]
        public string DescricaoPeca { get; set; }

        [JsonProperty("idMaterial")]
        public int? IdMaterial { get; set; }

        [JsonProperty("descricaoMaterial")]
        public string DescricaoMaterial { get; set; }

        [JsonProperty("materialTamanhoM2")]
        public decimal MaterialTamanhoM2 { get; set; }

        [JsonProperty("materialTamanhoML")]
        public decimal MaterialTamanhoML { get; set; }
    }
}
