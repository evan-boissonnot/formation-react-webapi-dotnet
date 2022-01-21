using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuiviDrones.Api.Application;
using SuiviDrones.API.Interfaces;

namespace SuiviDrones.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthStatusDroneController : ControllerBase
    {
        #region Fields
        private IHealthStatusDroneRepository monRepository;
        #endregion

        #region Constructors
        public HealthStatusDroneController(IHealthStatusDroneRepository repository)
        {
            this.monRepository = repository;
        }
        #endregion

        #region Public methods
        [HttpGet]
        public IActionResult Get()
        {
            // HealthStatusDroneRepository repo = new();

            var list = this.monRepository.GetAll();

            return this.Ok(list);
        }
        #endregion
    }
}