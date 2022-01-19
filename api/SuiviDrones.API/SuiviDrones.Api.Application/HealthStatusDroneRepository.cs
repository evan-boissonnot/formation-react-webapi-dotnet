using SuiviDrones.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.Api.Application
{
    public class HealthStatusDroneRepository
    {
        #region Public methods
        public List<HealthStatusDrone> GetAll()
        {
            return new()
            {
                new HealthStatusDrone()
                {
                    Date = DateTime.Now.AddYears(-1),
                    HealthStatus = new() { Id = 1, Label = "Fonctionnel" },
                    Drone = new() { Id = 1, Matricule = "XD100" },

                },
                new()
                {
                    Date = DateTime.Now.AddMonths(-1),
                    HealthStatus = new() { Id = 2, Label = "Abîmé par corbeau" },
                    Drone = new() { Id = 1, Matricule = "XD100" },

                },
                new()
                {
                    Date = DateTime.Now.AddMonths(3),
                    HealthStatus = new() { Id = 3, Label = "Abîmé par une mouette" },
                    Drone = new() { Id = 2, Matricule = "YD102" },

                }
            };
        }
        #endregion
    }
}
