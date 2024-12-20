using eCommerce.Application.DTO.Category;

namespace eCommerce.Application.DTO.Product
{
    public class GetProduct : ProductBaseModel
    {
        public int Id { get; set; }
        public GetCategory Category { get; set; } = null!;

    }
}
