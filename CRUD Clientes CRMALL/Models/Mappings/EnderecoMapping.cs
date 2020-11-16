using FluentNHibernate.Mapping;

namespace CRUD_Clientes_CRMALL.Models.Mappings
{
    public class EnderecoMapping : ClassMap<Endereco>
    {
        public EnderecoMapping()
        {
            Table(Endereco.TABELA);
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Bairro);
            Map(x => x.Cep);
            Map(x => x.Cidade);
            Map(x => x.Complemento);
            Map(x => x.Estado);
            Map(x => x.Logradouro);
            Map(x => x.Numero);
        }
    }
}