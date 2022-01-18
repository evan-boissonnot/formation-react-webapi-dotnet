using System;
using System.Collections.Generic;

namespace SuiviDrones.API.Models
{
    public partial class DroneHealthStatus
    {
        public decimal DroneId { get; set; }
        public decimal HealthStatusId { get; set; }
        public DateTime Date { get; set; }
        public decimal HealthReasonId { get; set; }

        public virtual Drone Drone { get; set; } = null!;
        public virtual HealthReason HealthReason { get; set; } = null!;
        public virtual HealthStatus HealthStatus { get; set; } = null!;
    }
}
