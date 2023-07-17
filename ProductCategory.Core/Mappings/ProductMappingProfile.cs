using AutoMapper;
using ProductCategory.Core.Dtos;
using ProductCategory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Core.Mappings
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile() { 
        CreateMap<Product,ProductDto>();
            CreateMap<ProductCreationDto, Product>();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
        }
    }
}
