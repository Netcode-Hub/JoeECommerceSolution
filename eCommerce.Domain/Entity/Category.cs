using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entity
{
    public class Category
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }

    }


}
