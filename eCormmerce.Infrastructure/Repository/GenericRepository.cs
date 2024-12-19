using eCormmerce.Infrastructure.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCormmerce.Infrastructure.Repository
{
    public abstract class GenericRepository<TEntity>(AppDbContext context) where TEntity : class
    {
        public void Add(TEntity entity) => context.Add(entity);
        public void Update(TEntity entity) => context.Update(entity);

        public async Task<TEntity?> Get(int id) => await context.Set<TEntity>().FindAsync(id);
        public async Task<IEnumerable<TEntity>> GetAll() => await context
            .Set<TEntity>()
            .AsNoTracking()
            .ToListAsync();      
    }
}
