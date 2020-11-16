using CRUD_Clientes_CRMALL.App_Start;
using CRUD_Clientes_CRMALL.Mappers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace CRUD_Clientes_CRMALL
{
    public class MvcApplication : System.Web.HttpApplication
    {
        internal static readonly IUnityContainer Container = new UnityContainer();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfig.RegisterMappings();
            ContainerRegistration.Register(Container);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
