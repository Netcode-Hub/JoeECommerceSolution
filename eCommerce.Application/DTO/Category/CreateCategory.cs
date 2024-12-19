using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.DTO.Category
{
    public class CreateCategory
    {
        public string? Name { get; set; }
    }

    public class UpdateCategory : CreateCategory
    {
        public int Id { get; set; }
    }

    public class GetCategory : UpdateCategory
    {

    }
    public class DeleteCategory : UpdateCategory { }
}
