using System;
using System.Collections.Generic;

namespace SuiviDrones.API.Models
{
    public partial class HealthStatus
    {
        public HealthStatus()
        {
            DroneHealthStatuses = new HashSet<DroneHealthStatus>();
        }

        public decimal Id { get; set; }
        public string Label { get; set; } = null!;

        public virtual ICollection<DroneHealthStatus> DroneHealthStatuses { get; set; }
    }
}
