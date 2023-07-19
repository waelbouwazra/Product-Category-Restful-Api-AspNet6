using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCategory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Repo.Data
{
    public class CategoryData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Code = "C1",
                    Label = "Category 1",
                    Description = "Category Description 1",

                },
                  new Category
                  {
                      Id = 2,
                      Code = "C2",
                      Label = "Category 2",
                      Description = "Category Description 2",

                  });
        }
    }
}
