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
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryCreationDto, Category>();
            CreateMap<CategoryUpdateDto, Category>().ReverseMap();
        }
    }
}
