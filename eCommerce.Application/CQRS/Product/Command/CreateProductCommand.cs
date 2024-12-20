using eCommerce.Application.DTO.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.CQRS.Product.Command
{
    public record CreateProductCommand(CreateProduct Product) : IRequest<string>;
}
