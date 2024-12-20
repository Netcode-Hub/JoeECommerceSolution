using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Exceptions
{
    public class AlreadyExistException(string message) : Exception(message)
    {
    }
}
