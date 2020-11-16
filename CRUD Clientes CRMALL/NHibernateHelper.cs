using CRUD_Clientes_CRMALL.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace CRUD_Clientes_CRMALL
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MySQLConfiguration.Standard
                  .ConnectionString(@"Server=localhost;Database=clientesdb;User ID=root;Password=admin")
                              .ShowSql()
                )
               .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Cliente>())
               .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
               .BuildSessionFactory();

            return sessionFactory.OpenSession();
        }
    }
}