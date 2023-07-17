using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Core.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Label { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Description { get; set; }
        public string? Code { get; set; }
    }
    public class CategoryCreationDto : CategoryAddUpdateDto
    {
        
    }

    public class CategoryUpdateDto : CategoryAddUpdateDto { }
    public class CategoryAddUpdateDto
    {
        [Required]
        [MaxLength(100)]
        public string? Label { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Description { get; set; }
        public string? Code { get; set; }
    }
}
