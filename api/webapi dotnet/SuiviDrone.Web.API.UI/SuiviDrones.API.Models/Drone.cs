using System;
using System.Collections.Generic;

namespace SuiviDrones.API.Models
{
    public partial class Drone
    {
        public Drone()
        {
            DroneHealthStatuses = new HashSet<DroneHealthStatus>();
            DroneHistories = new HashSet<DroneHistory>();
        }

        public decimal Id { get; set; }
        public string Matricule { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public decimal? DroneTypeId { get; set; }
        public decimal? HealthStatusId { get; set; }

        public virtual DroneType? DroneType { get; set; }
        public virtual ICollection<DroneHealthStatus> DroneHealthStatuses { get; set; }
        public virtual ICollection<DroneHistory> DroneHistories { get; set; }
    }
}
