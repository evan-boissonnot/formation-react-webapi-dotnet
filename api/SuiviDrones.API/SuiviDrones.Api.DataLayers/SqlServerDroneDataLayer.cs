using Microsoft.Extensions.Configuration;
using SuiviDrones.API.Interfaces;
using SuiviDrones.API.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.Api.DataLayers
{
    public class SqlServerDroneDataLayer : IDroneDataLayer
    {
        #region Fields
        private readonly string connectionString;
        #endregion

        #region Constructors
        public SqlServerDroneDataLayer(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("SuiviDrones.Database");
        }
        #endregion

        public List<Drone> GetAll()
        {
            List<Drone> list = new List<Drone>();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    //command.CommandText = "Nom de la PS";
                    //command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "SELECT Id, Matricule FROM Drone";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //reader.GetInt32(0)
                            var id = reader["Id"];
                            Drone drone = new Drone()
                            {
                                Id = Convert.ToInt32(id),
                                Matricule = Convert.ToString(reader["Matricule"])
                            };

                            list.Add(drone);
                        }
                    }
                }
            }

            return list;
        }
    }
}
