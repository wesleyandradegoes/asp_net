using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CRUD_Clientes_CRMALL.ViewModel
{
    public class EnderecoViewModel
    {
        public long Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Estado Estado { get; set; }
        public string Cidade { get; set; }

        public string EnderecoConcatenado { get => string.IsNullOrEmpty(this.Logradouro) ? "" : $"{Logradouro}, {Numero} - {Bairro}, {Cidade} - {Estado}, {Cep}"; }

    }
}