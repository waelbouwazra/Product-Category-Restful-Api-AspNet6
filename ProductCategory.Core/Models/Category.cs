using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Core.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Label { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Description { get; set; }
        public string? Code { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
