using Microsoft.AspNetCore.Mvc;
using SuiviDrones.API.Interfaces;
using SuiviDrones.API.Models;

namespace SuiviDrones.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivraisonController : ControllerBase
    {
        //private readonly IDeliveryRepository repository = null;

        //public LivraisonController(IDeliveryRepository repository)
        //{
        //    this.repository = repository;
        //}
        public LivraisonController()
        {

        }


        //public IActionResult Post(Delivery item)
        [HttpPost]
        public IActionResult Post(Delivery delivery) // (1° etape : string address)
        {
            // this.repository.Create(item);

            return this.Ok(new { Date = DateTime.Now });
        }
    }

    //public class TestOne
    //{
    //    public string Surname { get; set; }
    //    public string Address { get; set; }
    //}
}
