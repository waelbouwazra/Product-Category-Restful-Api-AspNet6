using ProductCategory.Core.Models;
using ProductCategory.Repo.Data;
using ProductCategory.Repo.GenericRepo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Repo.GenericRepo.Service
{
    public class ProductRepository : BaseRepo<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
