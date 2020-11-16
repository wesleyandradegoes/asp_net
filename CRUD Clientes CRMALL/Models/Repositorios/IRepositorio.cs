using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Clientes_CRMALL.Models.Repositorios
{
    public interface IRepositorio<T>
    {
        T Get(long id);
        void Save(T entidade);
        void Update(T entidade);
        IList<T> GetAll();
        void Delete(long id);

    }
}