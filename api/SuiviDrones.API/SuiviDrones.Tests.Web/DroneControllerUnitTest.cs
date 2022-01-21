using Microsoft.AspNetCore.Mvc;
using SuiviDrones.Api.Application;
using SuiviDrones.Api.DataLayers;
using SuiviDrones.API.Controllers;
using SuiviDrones.API.Interfaces;
using SuiviDrones.API.Models;
using System.Collections.Generic;
using Xunit;

namespace SuiviDrones.Tests.Web
{
    public class DroneControllerUnitTest
    {
        #region Public methods

        [Fact]
        public void ShouldRun()
        {
            // Arrange

            // Act

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void ShouldReturn2Drones()
        {
            // Arrange
            IDroneDataLayer droneLayer = null;

            Moq.Mock<IDroneDataLayer> mock = new Moq.Mock<IDroneDataLayer>();

            var maListDeDrones = new List<Drone>() { new() { }, new() { } };
            mock.Setup(item => item.GetAll()).Returns(maListDeDrones);

            droneLayer = mock.Object;

            var repository = new DatabaseDroneRepository(droneLayer);
            var controller = new DronesController(repository);

            // Act
            var result = controller.Get("");

            // Assert
            Assert.NotNull(result); 
            Assert.IsType<OkObjectResult>(result);

            OkObjectResult objectResult = (OkObjectResult)result;
            Assert.IsType<List<Drone>>(objectResult.Value);

            var list = objectResult.Value as List<Drone>;
            Assert.NotNull(list);
            Assert.Equal(2, list.Count);
        }
        #endregion
    }
}