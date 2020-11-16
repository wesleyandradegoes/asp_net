using AutoMapper;
using CRUD_Clientes_CRMALL.Models;
using CRUD_Clientes_CRMALL.Models.Repositorios;
using CRUD_Clientes_CRMALL.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;
using Unity;

namespace CRUD_Clientes_CRMALL.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IRepositorio<Cliente> repositorioCliente;
        // GET: Cliente

        public ClienteController()
        {
            repositorioCliente = MvcApplication.Container.Resolve<IRepositorio<Cliente>>();
        }

        public ActionResult Index()
        {
            var listaClientes = repositorioCliente.GetAll();
            var listaClientesViewModel = Mapper.Map<List<ClienteViewModel>>(listaClientes);
            return View(listaClientesViewModel);
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(ClienteViewModel novoCliente)
        {
                var cliente = Mapper.Map<Cliente>(novoCliente);

                if (cliente.Id > 0)
                    repositorioCliente.Update(cliente);
                else
                    repositorioCliente.Save(cliente);

                return RedirectToAction("Index");
        }

        public ActionResult Excluir(long id)
        {
            repositorioCliente.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Alterar(long id)
        {
            var cliente = repositorioCliente.Get(id);
            var clienteViewModel = Mapper.Map<ClienteViewModel>(cliente);
            return View("Novo", clienteViewModel);
        }
    }
}