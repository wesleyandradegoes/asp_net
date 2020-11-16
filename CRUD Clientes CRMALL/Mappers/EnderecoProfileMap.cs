using AutoMapper;
using CRUD_Clientes_CRMALL.Models;
using CRUD_Clientes_CRMALL.ViewModel;

namespace CRUD_Clientes_CRMALL.Mappers
{
    public class EnderecoProfileMap : Profile
    {
        public EnderecoProfileMap()
        {
            CreateMap<Endereco, EnderecoViewModel>(MemberList.None);
            CreateMap<EnderecoViewModel, Endereco>(MemberList.None);
        }
    }
}