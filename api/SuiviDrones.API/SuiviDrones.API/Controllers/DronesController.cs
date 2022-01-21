using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuiviDrones.API.Interfaces;
using SuiviDrones.API.Models;

namespace SuiviDrones.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DronesController : ControllerBase
    {
        #region Fields
        private readonly IDroneRepository repository;
        #endregion

        #region Constructors
        public DronesController(IDroneRepository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region Public methods
        [HttpGet]
        public IActionResult Get()
        {
            //List<Drone> listA = new List<Drone>();

            //var listD = new List<Drone>();
            //Drone drone = new();

            //// dotnet 5-6
            //List<Drone> list = new()
            //{
            //    new Drone() { Id = 1, Matricule = "x10FGGG" },
            //    new() { Id = 2, Matricule = "45FFGG" },
            //    drone
            //}; // List générique, qu'on a typé avec le type Drone

            //List<int> ids = new() { 1, 2, 3 };

            IActionResult result = this.BadRequest();

            try
            {
                var list = this.repository.GetAll();
                result = this.Ok(list);
            }
            catch (Exception)
            {
                
            }           


            return result; // .Select(item => item.Id)); pour renvoyer que les ids

            // return this.Ok(new { List1 = ids, Drones = list });
        }
        #endregion
    }
}
