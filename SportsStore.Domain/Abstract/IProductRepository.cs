using System.Linq;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    //Repository Pattern
    //Controller can request products without knowning how products are obtain
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Customer> Customers { get; }
        void Add(Customer cust);
        void Remove(Customer cust);
        void Edit(Customer cust);

    }
}
