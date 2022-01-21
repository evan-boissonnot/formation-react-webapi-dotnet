using SuiviDrones.API.Interfaces;
using SuiviDrones.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.Api.Application
{
    public class InMemoryDroneRepository : IDroneRepository
    {
        #region Public methods
        public List<Drone> GetAll()
        {
            Drone drone = new();

            // dotnet 5-6
            List<Drone> list = new()
            {
                new Drone() { Id = 1, Matricule = "x10FGGG" },
                new() { Id = 2, Matricule = "45FFGG" },
                drone
            }; // List générique, qu'on a typé avec le type Drone

            return list;
        }
        #endregion
    }
}
