using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductCategory.Core.Models;

namespace ProductCategory.Repo.Data
{
    public class RepositoryContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        public  RepositoryContext(DbContextOptions options):base(options) {
        
        }
        protected void onModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductData());
            modelBuilder.ApplyConfiguration(new CategoryData());

        }
    }
}
