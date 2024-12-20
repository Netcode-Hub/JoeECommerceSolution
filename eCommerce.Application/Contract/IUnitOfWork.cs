namespace eCommerce.Application.Contract
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
