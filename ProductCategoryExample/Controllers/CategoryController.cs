using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCategory.Core.Dtos;
using ProductCategory.Repo.GenericRepo.Interface;

namespace ProductCategoryExample.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : BaseApiController
    {
        public CategoryController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper) : base(repository, logger, mapper)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var categories = await _repository.Category.GetAllCategories(trackChanges: false);
                var categoriesDto = _mapper.Map<IEnumerable<CategoryDto>>(categories);
                return Ok(categoriesDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCategories)} action {ex}");
                return StatusCode(500, "Internal server error");
            }
            finally
            {
            }
        }
    }
    }
