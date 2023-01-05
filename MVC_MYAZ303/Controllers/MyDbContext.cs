using MVC_MYAZ303.Models;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace MVC_MYAZ303.Controllers
{
    internal class MyDbContext
    {
        public IEnumerable Customers { get; internal set; }
        public IEnumerable Products { get; internal set; }
        public object Orders { get; internal set; }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        internal void Add(Order order)
        {
            throw new NotImplementedException();
        }

        internal void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}