using NHibernate;
using System;
using System.Collections.Generic;

namespace CRUD_Clientes_CRMALL.Models.Repositorios
{
    public class Repositorio<T> : IRepositorio<T> where T : Entidade
    {
        T IRepositorio<T>.Get(long id)
        {
            ISession session = NHibernateHelper.OpenSession();
            return session.Get<T>(id);
        }

        public void Save(T entidade)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(entidade);
                transaction.Commit();
            }
        }

        public void Update(T entidade)
        {
            ISession session = NHibernateHelper.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(entidade);
                transaction.Commit();
            }
        }

        IList<T> IRepositorio<T>.GetAll()
        {
            ISession session = NHibernateHelper.OpenSession();
            return session.CreateCriteria<T>().List<T>();
        }

        public void Delete(long id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                var entidade = session.Get<T>(id);
                session.Delete(entidade);
                transaction.Commit();
            }
        }
    }
}