using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProductCategory.Core.Mappings;
using ProductCategory.Repo.Data;
using ProductCategory.Repo.GenericRepo.Interface;
using ProductCategory.Repo.GenericRepo.Service;

namespace ProductCategoryExample.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureLoggerService(this IServiceCollection services) =>
     services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("connectionString");

            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                          Initial Catalog=prodcat;
                                          Integrated Security=true;
                                          MultipleActiveResultSets=true"); // Replace with your MySQL server version
            });
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
            => services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureMapping(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });
            var mapperConfig = new MapperConfiguration(map =>
            {
                map.AddProfile<CategoryMappingProfile>();
                map.AddProfile<ProductMappingProfile>();
            });
            services.AddSingleton(mapperConfig.CreateMapper());
        }

        //Add Here
        public static void ConfigureControllers(this IServiceCollection services)
        {
            services.AddControllers(config =>
            {
                config.CacheProfiles.Add("120SecondsDuration", new CacheProfile
                {
                    Duration = 30
                });
            });
        }

        //Add Here
        public static void ConfigureResponseCaching(this IServiceCollection services) => services.AddResponseCaching();


        public static void RegisterDependencies(this IServiceCollection services)
        {
           
        }
    }
}
