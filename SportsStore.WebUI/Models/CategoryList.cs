using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Concrete;

namespace SportsStore.WebUI.Models
{
    public class CategoryList
    {
        public IEnumerable<Product> CategoriesList {get;set;}   
    }
}