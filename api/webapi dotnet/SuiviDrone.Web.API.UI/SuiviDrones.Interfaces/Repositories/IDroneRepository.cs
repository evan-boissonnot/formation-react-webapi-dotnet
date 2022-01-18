using SuiviDrones.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.Interfaces.Repositories
{
    public interface IDroneRepository
    {
        /// <summary>
        /// Gets all drones
        /// </summary>
        /// <returns></returns>
        IList<Drone> GetList();
    }
}
