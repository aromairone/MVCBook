using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Concrete;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Controllers
{
    public class CustomerController : Controller
    {        
        
        //private IEnumerable<Customer> customers;

        //Get list of customers
        //public CustomerController()
        //{
        //    customers = list.Customers;
        //}
        // GET: Customer
        public ViewResult Customer()
        {
            IProductRepository repository = new EFProductRepository();
            return View(repository.Customers);
        }
    }
}