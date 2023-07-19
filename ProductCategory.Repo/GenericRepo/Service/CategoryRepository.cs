using Microsoft.EntityFrameworkCore;
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
    public class CategoryRepository :BaseRepo<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            
        }

        public async Task CreateCategory(Category category)
        => await CreateAsync(category);

        public async Task<IEnumerable<Category>> GetAllCategories(bool trackChanges)
       =>
            await FindAllAsync(trackChanges).Result.OrderByDescending(c=>c.Code).ToListAsync();
        

       

        public async Task<Category> GetCategory(int categoryId, bool trackChanges)
            => await FindByConditionAsync(c => c.Id.Equals(categoryId), trackChanges).Result.SingleOrDefaultAsync();



    }
}
