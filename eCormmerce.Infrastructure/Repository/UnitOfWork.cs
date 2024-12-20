using eCommerce.Application.Contract;
using eCormmerce.Infrastructure.Repository.Data;

namespace eCormmerce.Infrastructure.Repository
{
    public class UnitOfWork(AppDbContext context) : IUnitOfWork
    {
        public async Task SaveChangesAsync() => await context.SaveChangesAsync();
        
    }
}
