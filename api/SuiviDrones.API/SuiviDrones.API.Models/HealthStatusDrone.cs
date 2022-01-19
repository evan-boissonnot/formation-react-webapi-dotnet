using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.API.Models
{
    public class HealthStatusDrone
    {
        #region Properties
        public Drone Drone { get; set; }

        public HealthStatus HealthStatus { get; set; }

        public DateTime Date { get; set; }
        #endregion
    }
}
