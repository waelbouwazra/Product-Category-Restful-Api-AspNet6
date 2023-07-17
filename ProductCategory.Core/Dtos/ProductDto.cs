using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Core.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public string? Image { get; set; }
        public double Price { get; set; }

    }
    public class ProductCreationDto : ProductAddUpdateDto
    {

    }
    public class ProductUpdateDto : ProductAddUpdateDto { }

    public abstract class ProductAddUpdateDto
    {
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]

        public string? Name { get; set; }
        [MaxLength(30, ErrorMessage = "Maximum length for the Description is 30 characters.")]

        public string? Description { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public string? Code { get; set; }

    }
}
