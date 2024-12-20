using eCommerce.Application.Contract;
using eCommerce.Domain.Entity;
using eCormmerce.Infrastructure.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCormmerce.Infrastructure.Repository
{
    public class ProductRepository(AppDbContext context) : GenericRepository<Product>(context), IProduct
    {
        public async Task Delete(int id)
        {
            var product = await Get(id);
            if (product != null)
                 context.Products.Remove(product);
            
        }
    }
}
