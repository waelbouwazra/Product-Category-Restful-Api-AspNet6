using ProductCategory.Core.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Repo.Data
{
    public class ProductData : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Description = "Product 1 Description",
                    Code = "P1",
                    CategoryId = 1,
                    Price = 12.2,
                    Image = "test"
                },
                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Description = "Product 2 Description",
                    Code = "P2",
                    CategoryId = 1,
                    Price = 13.9,
                    Image = "testImage"
                });
        }
    }
}
