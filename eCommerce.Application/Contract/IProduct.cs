using eCommerce.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Contract
{
    public interface IProduct
    {
        void Add(Product product);
        void Update(Product product);
        Task Delete(int id);
        Task<Product?> Get(int id);
        Task<IEnumerable<Product>> GetAll();
    }

    public interface ICategory
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        Task<Category?> Get(int id);
        Task<IEnumerable<Category>> GetAll();
    }
}
