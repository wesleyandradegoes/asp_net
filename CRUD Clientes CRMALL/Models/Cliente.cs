using System;

namespace CRUD_Clientes_CRMALL.Models
{
    public class Cliente : Entidade
    {
        public const string TABELA = "CLIENTE";

        public virtual string Nome { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual Sexo Sexo { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}