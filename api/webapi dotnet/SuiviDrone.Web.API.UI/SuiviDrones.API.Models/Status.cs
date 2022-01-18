using System;
using System.Collections.Generic;

namespace SuiviDrones.API.Models
{
    public partial class Status
    {
        public Status()
        {
            DroneHistories = new HashSet<DroneHistory>();
        }

        public decimal Id { get; set; }
        public string Label { get; set; } = null!;

        public virtual ICollection<DroneHistory> DroneHistories { get; set; }
    }
}
