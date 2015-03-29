using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;
using SportStore.WebUI.Controllers;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using SportStore.WebUI.Models;
using SportStore.WebUI.HtmlHelpers;

namespace SportStore.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void Can_Pageinate()
        //{
        //    //Arrange
        //    Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
        //    mock.Setup(m => m.Products).Returns(new Product[]{
        //    new Product{ProductId = 1, Name = "P1"},
        //    new Product{ProductId = 2, Name = "P2"},
        //    new Product{ProductId = 3, Name = "P3"},
        //    new Product{ProductId = 4, Name = "P4"},
        //    new Product{ProductId = 5, Name = "P5"}
        //    });
        //    ProductController controller = new ProductController(mock.Object);
        //    //Act   
        //    IEnumerable<Product> result = (IEnumerable<Product>)controller.List(2).Model;
        //    //Assert
        //    Product[] prodArray = result.ToArray();
        //    Assert.IsTrue(prodArray.Length == 2);
        //    Assert.AreEqual(prodArray[0].Name, "P4");
        //    Assert.AreEqual(prodArray[1].Name, "P5");
        //}
        [TestMethod]
        public void Can_Generate_Page_Links()
        {
            //arrange - define and HTML helper
            //in order to apply the helper method
            HtmlHelper myHelper = null;
            //arrange - create PagingInfo data
            PagingInfoVM pagingInfo = new PagingInfoVM{
                CurrentPage = 2,
                TotalItems = 28,
                ItemsPerPage = 10
            };
            //arrange - setup the delegate using lambda expression
            Func<int, string> pageUrlDelegat = i => "Page" + i;
            //act 
            MvcHtmlString result = myHelper.PageLinks(pagingInfo, pageUrlDelegat);
            //assert
            Assert.AreEqual(@"<a class=""btn btn-default"" href=""Page1"">1</a>"       + @"<a class=""btn btn-default btn-primary selected"" href=""Page2"">2</a>"                + @"<a class=""btn btn-default"" href=""Page3"">3</a>",                result.ToString()); 
        }
    }
}
