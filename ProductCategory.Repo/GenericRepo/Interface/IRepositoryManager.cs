using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Repo.GenericRepo.Interface
{
    public interface IRepositoryManager
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        Task SaveAsync();

    }
}
