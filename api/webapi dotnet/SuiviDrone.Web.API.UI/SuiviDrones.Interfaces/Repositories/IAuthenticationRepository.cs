using SuiviDrones.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.Interfaces.Repositories
{
    public interface IAuthenticationRepository
    {
        /// <summary>
        /// Try to get the user with email and password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<User> Login(string email, string password);

        Task<User> Create(User user);
    }
}
