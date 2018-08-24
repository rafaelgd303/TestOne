using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestOne.Interfaces;
using TestOne.Models;
using TestOne.Services;
using System.Linq;

namespace TestOne.Tests.Service
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void SetCount_When()
        {
            //Arrange
            var mock = new Mock<IFizzBuzzRepository>();
            mock.Setup(x => x.AddFizzBuzz(It.IsAny<List<FizzBuzz>>()));
            var service = new FizzBuzzService(mock.Object);

            //Act
            var result = service.SetCount(100).ToList();

            //Assert
            Assert.AreEqual(100, result.Count);

        }
        [TestMethod]
        public void SetCount_WhenRangeInModulo3And5_ReturnProperResult()
        {
            //Arrange

            var mock = new Mock<IFizzBuzzRepository>();
            mock.Setup(x => x.AddFizzBuzz(It.IsAny<List<FizzBuzz>>()));
            var service = new FizzBuzzService(mock.Object);
            


            //Act
            var result = service.SetCount(100).ToList();

            //Assert
            Assert.AreEqual("fizz buzz", result[14].Text);
            Assert.AreEqual("fizz buzz", result[29].Text);
            Assert.AreEqual(94, result.Count(x => x.Text != "fizz buzz"));

        }
    }
}
