using eCommerce.Domain.Entity;

namespace eCommerce.Application.Contract
{
    public interface ICategory
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        Task<Category?> Get(int id);
        Task<IEnumerable<Category>> GetAll();
        Task<bool> IsAvailableByName(string name);
    }
}
