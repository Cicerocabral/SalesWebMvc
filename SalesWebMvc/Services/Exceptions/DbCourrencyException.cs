using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbCourrencyException : ApplicationException
    {
        public DbCourrencyException (string message) : base(message)
        {

        }
    }
}
