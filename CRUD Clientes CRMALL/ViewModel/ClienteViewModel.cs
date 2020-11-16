using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Clientes_CRMALL.ViewModel
{
    public class ClienteViewModel
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Sexo Sexo { get; set; }

        public EnderecoViewModel Endereco { get; set; }        
    }
}