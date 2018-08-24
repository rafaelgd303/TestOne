using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestOne;
using TestOne.Controllers;
using TestOne.Interfaces;
using TestOne.Models;
using TestOne.Services;

namespace TestOne.Tests.Controllers
{
    [TestClass]
    public class FizzBuzzControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var mock = new Mock<IFizzBuzzService>();
            var list = new List<FizzBuzz>()
            {
                new FizzBuzz
                {
                    Color ="Red",
                    Text = "dupa"
                },
                new FizzBuzz
                {
                    Color ="blue",
                    Text = "dupa2"
                }
            };
            mock.Setup(x => x.GetList()).Returns(list);
            var controller = new FizzBuzzController(mock.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;
            var listTest = (BuzzViewModel)result.ViewData.Model;


            // Assert
            Assert.IsNotNull(result);
            CollectionAssert.Equals(listTest, list);
            
        }
        
    }
}
