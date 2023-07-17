using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]

        public string? Name { get; set; }
        [MaxLength(30, ErrorMessage = "Maximum length for the Description is 30 characters.")]

        public string Description { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public string? Code { get; set; }
        public virtual Category Category { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

    }
}
