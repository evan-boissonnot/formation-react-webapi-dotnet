using Microsoft.AspNetCore.Mvc;
using Moq;
using SuiviDrones.API.Controllers;
using SuiviDrones.API.Interfaces;
using SuiviDrones.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SuiviDrones.Tests.Web
{
    public class LivraisonControllerUnitTest
    {
        #region Public methods
        [Fact]
        public void ShouldRun()
        {
            Assert.True(1 == 1);
        }

        [Fact]
        public void ShouldCreateAndGetNewDelivery()
        {
            // ARRANGE
            var mock = new Moq.Mock<IDeliveryRepository>();

            mock.Setup(x => x.Create(It.IsAny<Delivery>())).Callback<Delivery>(item =>
            {
                item.Id = 1;
            });

            var controller = new LivraisonController();
            var delivery = new Delivery();

            // ACT
            var result = controller.Post(delivery);

            // ASSERT
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
            var data = (result as OkObjectResult).Value;

            Assert.NotNull(data);
            Assert.IsType<Delivery>(data);

            Assert.NotEqual(0, (data as Delivery).Id);
        }
        #endregion
    }
}
