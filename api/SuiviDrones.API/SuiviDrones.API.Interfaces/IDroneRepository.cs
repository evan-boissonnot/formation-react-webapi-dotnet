using SuiviDrones.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.API.Interfaces
{
    /// <summary>
    /// Repo qui gère les règles métier des drones
    /// Les récupère
    /// Permet l'ajout ....
    /// </summary>
    public interface IDroneRepository
    {
        /// <summary>
        /// Ramène TOUS les drones (ATTENTION)
        /// </summary>
        /// <returns></returns>
        List<Drone> GetAll();
    }
}
