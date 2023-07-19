using ProductCategory.Repo.Data;
using ProductCategory.Repo.GenericRepo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Repo.GenericRepo.Service
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;

        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository is null)
                    _productRepository = new ProductRepository(_repositoryContext);
                return _productRepository;
            }
        }
        public ICategoryRepository Category
        {
            get
            {
                if (_categoryRepository is null)
                    _categoryRepository = new   CategoryRepository(_repositoryContext);
                return _categoryRepository;
            }
        }
        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
