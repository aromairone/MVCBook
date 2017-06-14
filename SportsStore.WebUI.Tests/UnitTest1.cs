using System;
using SportsStore.Domain;
using SportsStore.WebUI;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SportsStore.WebUI.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            Mock<SportsStore.Domain.Abstract.IProductRepository> mock = new Mock<Domain.Abstract.IProductRepository>();
            mock.Setup(m => m.Products).Returns(new SportsStore.Domain.Entities.Product[]
            {
                new Domain.Entities.Product {ProductId = 1, Name = "P1" },
                new Domain.Entities.Product { ProductId=2, Name="P2"},
                new Domain.Entities.Product {ProductId = 3, Name = "P3" },
                new Domain.Entities.Product { ProductId=4, Name="P4"},
                new Domain.Entities.Product {ProductId = 5, Name = "P5" },
                new Domain.Entities.Product { ProductId=6, Name="P6"},
                new Domain.Entities.Product {ProductId = 7, Name = "P7" },
                new Domain.Entities.Product { ProductId=8, Name="P8"}
            }.AsQueryable());
            //Create controller
            SportsStore.WebUI.Controllers.ProductController controller = new SportsStore.WebUI.Controllers.ProductController(mock.Object);
            controller.PageSize = 3;
            SportsStore.WebUI.Models.ProductListViewModel result = (SportsStore.WebUI.Models.ProductListViewModel)controller.List(null, 2).Model;

            //Assert
            SportsStore.Domain.Entities.Product[] prodArray = result.Products.ToArray();
            Assert.IsTrue(prodArray.Length == 3);
            Assert.AreEqual(prodArray[0].Name, "P4");
            Assert.AreEqual(prodArray[1].Name, "P5");

        }
    }
}
