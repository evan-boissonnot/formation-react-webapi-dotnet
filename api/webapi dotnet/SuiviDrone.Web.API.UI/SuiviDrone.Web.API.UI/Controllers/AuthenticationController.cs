using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuiviDrones.Interfaces.Repositories;

namespace SuiviDrone.Web.API.UI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        #region Fields
        private readonly IAuthenticationRepository repository = null!;
        #endregion

        #region Constructors
        public AuthenticationController(IAuthenticationRepository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region Public methods
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(string login, string password, string name)
        {
            IActionResult result = this.BadRequest();

            try
            {
                result = this.Ok(await this.repository.Create(new () { UserName = login, Email = login, Password = password }));
            }
            catch (Exception)
            {
                result = this.Problem("Failed to create new user");
            }

            return result;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Login(string login, string password)
        {
            IActionResult result = this.BadRequest();

            try
            {
                result = this.Ok(await this.repository.Login(login, password));
            }
            catch (Exception)
            {
                result = this.Problem("Failed to log");
            }

            return result;
        }
        #endregion
    }
}
