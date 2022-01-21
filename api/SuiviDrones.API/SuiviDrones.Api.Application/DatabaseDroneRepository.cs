using Microsoft.Extensions.Configuration;
using SuiviDrones.API.Interfaces;
using SuiviDrones.API.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.Api.Application
{
    public class DatabaseDroneRepository : IDroneRepository
    {
        #region Fields
        private readonly IDroneDataLayer layer;
        #endregion

        #region Constructors
        public DatabaseDroneRepository(IDroneDataLayer layer)
        {
            this.layer = layer;
        }
        #endregion


        public List<Drone> GetAll()
        {
            var list =  this.layer.GetAll();
            // Vos regles fonctionnelles

            return list;
        }
    }
}
