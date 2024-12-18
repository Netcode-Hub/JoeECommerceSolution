using eCommerce.Application.DTO.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.DTO.Product
{
    public class CreateProduct : BaseModel
    {
        public int CategoryId { get; set; }
    }

    public class UpdateProduct : BaseModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
    }

    public class GetProduct : BaseModel
    {
        public int Id { get; set; }
        public GetCategory Category { get; set; } = null!;
    }

    public class BaseModel
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }
    }
}
