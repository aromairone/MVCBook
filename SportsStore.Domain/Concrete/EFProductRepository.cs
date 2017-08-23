using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Abstract;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }

        public IQueryable<Customer> Customers
        {
            get { return context.Customers; }
        }
        public void Add(Customer cust)
        {
            try
            {
                context.Customers.Add(cust);
                context.SaveChanges();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public void Remove(Customer cust)
        {
            context.Customers.Remove(cust);
            context.SaveChanges();
        }
        public void Edit(Customer cust)
        {
            context.Entry(cust).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
