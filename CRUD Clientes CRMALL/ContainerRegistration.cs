using CRUD_Clientes_CRMALL.Models;
using CRUD_Clientes_CRMALL.Models.Repositorios;
using Unity;

namespace CRUD_Clientes_CRMALL
{
    public static class ContainerRegistration
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IRepositorio<Cliente>, Repositorio<Cliente>>();
        }
    }
}