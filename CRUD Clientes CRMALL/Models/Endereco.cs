namespace CRUD_Clientes_CRMALL.Models
{
    public class Endereco : Entidade
    {
        public const string TABELA = "ENDERECO";

        public virtual string Cep { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual int Numero { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string Estado { get; set; }
        public virtual string Cidade { get; set; }
    }
}