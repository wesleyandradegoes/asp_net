using AutoMapper;

namespace CRUD_Clientes_CRMALL.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ClienteProfileMap>();
                x.AddProfile<EnderecoProfileMap>();
            });
        }

    }
}