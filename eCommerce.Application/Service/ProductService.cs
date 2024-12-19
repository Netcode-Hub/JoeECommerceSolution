using eCommerce.Application.DTO.Category;
using eCommerce.Application.DTO.Product;
using eCommerce.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Service
{
    public interface IProductService
    {
        void Add(CreateProduct product);
        void Update(UpdateProduct product);
        Task Delete(int id);
        Task<GetProduct?> Get(int id);
        Task<IEnumerable<GetProduct>> GetAll();
    }

    public interface ICategoryService
    {
        void Add(CreateCategory category);
        void Update(UpdateCategory category);
        void Delete(DeleteCategory category);
        Task<GetCategory?> Get(int id);
        Task<IEnumerable<GetCategory>> GetAll();
    }
}
