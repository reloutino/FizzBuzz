using System;
using FizzBuzzConvertionLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzConvertionLibraryUnitTests
{
    [TestClass]
    public class FizzBuzzConvertionServiceUnitTests
    {
        FizzBuzzConvertionService _fizzBuzzConvertionService;
        [TestInitialize]
        public void TestInit()
        {
            _fizzBuzzConvertionService = new FizzBuzzConvertionService();
        }

        [TestMethod]
        public void TestMultipleOf3()
        {
            //Arrange
            var input = 6;
            //Act
            var result = _fizzBuzzConvertionService.Convert(input);
            //Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void TestMultipleOf5()
        {
            //Arrange
            var input = 20;
            //Act
            var result = _fizzBuzzConvertionService.Convert(input);
            //Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void TestMultipleOf3and5()
        {
            //Arrange
            var input = 30;
            //Act
            var result = _fizzBuzzConvertionService.Convert(input);
            //Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void TestNotMultipleOf3Or5()
        {
            //Arrange
            var input = 14;
            //Act
            var result = _fizzBuzzConvertionService.Convert(input);
            //Assert
            Assert.AreEqual("14", result);
        }
    }
}
