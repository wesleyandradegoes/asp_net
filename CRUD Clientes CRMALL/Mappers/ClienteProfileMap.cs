using AutoMapper;
using CRUD_Clientes_CRMALL.Models;
using CRUD_Clientes_CRMALL.ViewModel;

namespace CRUD_Clientes_CRMALL.Mappers
{
    public class ClienteProfileMap : Profile
    {
        public ClienteProfileMap()
        {
            CreateMap<Cliente, ClienteViewModel>(MemberList.None);
            CreateMap<ClienteViewModel, Cliente>(MemberList.None);
        }
    }
}