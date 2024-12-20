using eCommerce.Application.Contract;
using eCommerce.Domain.Entity;
using eCormmerce.Infrastructure.Repository.Data;

namespace eCormmerce.Infrastructure.Repository
{
    public class CategoryRepository(AppDbContext context) : GenericRepository<Category>(context), ICategory
    {
        public void Delete(Category category) => context.Categories.Remove(category);
        
    }
}
