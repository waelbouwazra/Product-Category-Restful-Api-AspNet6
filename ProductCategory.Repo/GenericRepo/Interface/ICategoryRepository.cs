using ProductCategory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Repo.GenericRepo.Interface
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories(bool trackChanges);
        Task<Category> GetCategory(int categoryId, bool trackChanges);
        Task CreateCategory(Category category);
    }
}
