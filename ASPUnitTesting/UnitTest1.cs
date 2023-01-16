using ASPTest.Controllers;
using ASPTest.Models;
using ASPTest.Service;
using Microsoft.AspNetCore.Mvc;

namespace ASPUnitTesting
{
    public class BeerTesting
    {

        private readonly BeerController _controller;
        private readonly IBeerService _service;


        public BeerTesting()
        { 
           
            _service = new BeerService();
            _controller = new BeerController(_service);
        }

        [Fact]
        public void Get_Ok()
        {
            var result = _controller.Get();

            Assert.IsType<OkObjectResult>(result);
        }


        [Fact]
        public void Get_Quality()
        {
            var result = (OkObjectResult)_controller.Get();
            var beers = Assert.IsType <List<Beer>>(result.Value);

            Assert.True(beers.Count > 0);
        }


        [Fact]
        public void GetById_Ok() 
        {

            int id = 1;
            var result = _controller.GetById(id);

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_Exists() 
        {
            // Arrange - preparación
            int id = 1;
            
            //Act - acto - ejecución
            var result = (OkObjectResult)_controller.GetById(id);

            //Assert - confirmación - evaluadores
            var beer = Assert.IsType<Beer>(result?.Value);
            Assert.True(beer != null);
            Assert.Equal(beer?.Id,id);
        }


        [Fact]
        public void GetById_NotFound()
        {
            int id = 3;

            var result = _controller.GetById(id);

            var beer = Assert.IsType<NotFoundResult>(result);
        }
    }
}