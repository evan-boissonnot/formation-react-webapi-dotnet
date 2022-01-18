using System;
using System.Collections.Generic;

namespace SuiviDrones.API.Models
{
    public partial class HealthReason
    {
        public HealthReason()
        {
            DroneHealthStatuses = new HashSet<DroneHealthStatus>();
        }

        public decimal Id { get; set; }
        public string Label { get; set; } = null!;

        public virtual ICollection<DroneHealthStatus> DroneHealthStatuses { get; set; }
    }
}
