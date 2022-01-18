using SuiviDrones.API.Infrastructures;
using SuiviDrones.API.Models;
using SuiviDrones.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.API.Repositories
{
    public class DroneRepository : IDroneRepository
    {
        #region Fields
        private readonly SuiviDronesContext _context = null!;
        #endregion

        #region Constructors
        public DroneRepository(SuiviDronesContext context)
        {
            this._context = context;
        }
        #endregion

        #region Public methods
        public IList<Drone> GetList()
        {
            return this._context.Drones.ToList();
        }
        #endregion
    }
}
