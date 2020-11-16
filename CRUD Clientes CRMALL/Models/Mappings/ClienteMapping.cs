using FluentNHibernate.Mapping;

namespace CRUD_Clientes_CRMALL.Models.Mappings
{
    public class ClienteMapping : ClassMap<Cliente>
    {
        public ClienteMapping()
        {
            Table(Cliente.TABELA);
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Nome).Not.Nullable();
            Map(x => x.DataNascimento).Not.Nullable();
            Map(x => x.Sexo).Not.Nullable();
            References(x => x.Endereco).Cascade.All().Nullable();
        }
    }
}