using System;
using System.Collections.Generic;

namespace SuiviDrones.API.Models
{
    public partial class DroneType
    {
        public DroneType()
        {
            Drones = new HashSet<Drone>();
        }

        public decimal Id { get; set; }
        public string Label { get; set; } = null!;

        public virtual ICollection<Drone> Drones { get; set; }
    }
}
