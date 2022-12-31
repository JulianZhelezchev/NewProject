using AutoMapper;
using StoreWebSystem.Data.Models;
using StoreWebSystem.Models;

namespace StoreWebSystem.AutoMapper
{

        public class AutomapperProfile : Profile
        {
            public AutomapperProfile()
            {
                CreateMap<CategoryDto, Categories>()
                    .ReverseMap();

                CreateMap<ProductDto, ProductsInfo>()
                    .ReverseMap();
            }
        }


    
}
