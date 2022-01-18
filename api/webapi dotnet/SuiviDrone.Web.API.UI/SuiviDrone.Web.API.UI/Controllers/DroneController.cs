using Microsoft.AspNetCore.Mvc;
using SuiviDrones.Interfaces.Repositories;

namespace SuiviDrone.Web.API.UI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DroneController : ControllerBase
    {
        #region Fields
        private readonly IDroneRepository repository = null!;
        #endregion

        #region Constructors
        public DroneController(IDroneRepository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region Public methods
        [HttpGet]
        public IActionResult GetAll()
        {
            return this.Ok(this.repository.GetList());
        }
        #endregion
    }
}
