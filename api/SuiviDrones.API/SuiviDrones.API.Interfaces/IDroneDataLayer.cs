using SuiviDrones.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.API.Interfaces
{
    public interface IDroneDataLayer
    {
        List<Drone> GetAll();
    }
}
