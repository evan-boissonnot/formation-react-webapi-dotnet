using SuiviDrones.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.Interfaces.Services
{
    public interface ITokenGenerator
    {
        /// <summary>
        /// Generate new token to authenticate user
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        string GenerateToken(TokenConfig arg);
    }
}
