using eCommerce.Application.AutoMapper;
using eCommerce.Application.Validation.Product;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace eCommerce.Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
           services.AddValidatorsFromAssemblyContaining<CreateProductValidator>();
            services.AddAutoMapper(typeof(MapperConfig));
            return services;
        }
    }
}
