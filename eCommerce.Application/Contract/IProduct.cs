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
        Task<bool> IsAvailableByName(string name);
    }
}
