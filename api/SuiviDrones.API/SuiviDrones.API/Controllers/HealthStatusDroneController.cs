using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuiviDrones.Api.Application;

namespace SuiviDrones.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthStatusDroneController : ControllerBase
    {
        #region Public methods
        [HttpGet]
        public IActionResult Get()
        {
            HealthStatusDroneRepository repo = new();

            var list = repo.GetAll();

            return this.Ok();
        }
        #endregion
    }
}
