using System;
using System.Collections.Generic;

namespace SuiviDrones.API.Models
{
    public partial class DroneHistory
    {
        public decimal Id { get; set; }
        public DateTime Date { get; set; }
        public decimal DroneId { get; set; }
        public decimal StatusId { get; set; }

        public virtual Drone Drone { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
    }
}
