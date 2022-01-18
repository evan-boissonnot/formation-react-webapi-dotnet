using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SuiviDrones.API.Infrastructures;
using SuiviDrones.API.Models;
using SuiviDrones.Interfaces.Repositories;
using SuiviDrones.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.API.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        #region Fields
        private readonly SuiviDronesContext context = null!;
        private readonly UserManager<User> userManager = null!;
        private readonly ITokenGenerator tokenGenerator = null!;
        #endregion

        #region Constructors
        public AuthenticationRepository(SuiviDronesContext context, 
                                        UserManager<User> userManager, 
                                        ITokenGenerator tokenGenerator)
        {
            this.context = context;
            this.userManager = userManager; 
            this.tokenGenerator = tokenGenerator;
        }
        #endregion

        #region Public methods
        public async Task<User> Create(User user)
        {
            var success = await this.userManager.CreateAsync(user, user.Password);

            if (! success.Succeeded)
            {
                throw new ArgumentException("Impossible to create user", "user");
            }

            user.Token = this.tokenGenerator.GenerateToken(new() { Email = user.Email, Id = user.Id });

            return user;
        }

        public async Task<User> Login(string email, string password)
        {
            User? user = null;

            user = await this.userManager.FindByEmailAsync(email);
            if (user == null)
                throw new ArgumentException("User not found", "email");

            var verif = await this.userManager.CheckPasswordAsync(user, password);
            if (! verif)
            {
                throw new ArgumentException("User not found", "password");
            }

            user.Token = this.tokenGenerator.GenerateToken(new () { Email = user.Email, Id = user.Id });

            return user;
        }
        #endregion
    }
}
