using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterWorkShop.Cinema.Data.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(int id) : base("Result is null with " + id)
        {
            
        }
    }
}
