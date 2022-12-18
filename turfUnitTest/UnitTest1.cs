// using Microsoft.AspNetCore.Mvc;
// using WebAPi.Controllers;
// using WebAPi.Models;

namespace turfUnitTest
{
    public class UnitTest1
    {

        // Test POssitive
        [Fact]
        public void PosTestEven()
        {
            //Arrange
            var num = 6;
            //Act
            var result = num % 2;           
            //Assert
            Assert.Equal(0,result);
        }

        // TestNegative
        [Fact]
        public void NegTestEven()
        {
            //Arrange
            var num = 7;
            //Act
            var result = num % 2;
            //Assert
            Assert.Equal(0, result);
        }


        // Add WbAPI to depencidies and you willg et build errors when testing
        // Alsu uncommand the using at the top 
        /*

        private readonly turfsController controller;       
        [Fact]
        public void getTurfsTest()
        {
            // Act
            var okResult = controller.Gettur as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<turf>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
        */


    }
}