using AutoMapper;
using ECommerce.Shared.Models;

namespace ECommerce.Server.Mapper
{
    public class AutoMapperDefaultProfile : Profile
    {
        public AutoMapperDefaultProfile()
        {
            CreateMap<ECommerce.Server.Models.Client , PasswordResource>();
            CreateMap<SharedClientModel, Models.Client>();
            CreateMap<ProductDto, Models.Product>();
            CreateMap<Models.Product, ProductDto>();

        }
    }
}
