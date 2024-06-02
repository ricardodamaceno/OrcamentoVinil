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

        [JsonProperty("materiaisVeiculo")]
        public List<MaterialVeiculo> MateriaisVeiculo { get; set; }
    }

    public class MaterialVeiculo
    {
        [JsonIgnore]
        public bool Ativo { get; set; } = true;

        [JsonIgnore]
        public string? PecaDescricao { get; set; }

        [JsonProperty("pecaID")]
        public int PecaID { get; set; }

        [JsonIgnore]
        public string? MaterialDescricao { get; set; }

        [JsonProperty("materialID")]
        public int MaterialID { get; set; }

        [JsonProperty("materialTamanhoM2")]
        public int MaterialTamanhoM2 { get; set; }

        [JsonProperty("materialTamanhoML")]
        public int MaterialTamanhoML { get; set; }
    }
}
