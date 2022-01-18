using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.API.Models
{
    public class User : IdentityUser
    {
        #region Properties
        public string Token { get; set; }

        public string Password { get; set; }
        #endregion
    }
}
