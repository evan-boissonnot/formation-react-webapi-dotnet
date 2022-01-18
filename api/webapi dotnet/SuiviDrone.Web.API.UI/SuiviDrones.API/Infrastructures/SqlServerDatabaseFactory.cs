using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.API.Infrastructures
{
    public class SqlServerDatabaseFactory : IDesignTimeDbContextFactory<SuiviDronesContext>
    {
        #region Public methods
        public SuiviDronesContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SuiviDronesContext>();
            ConfigurationBuilder builder = new ConfigurationBuilder();

            builder.AddJsonFile("appsettings.json");

            var conf = builder.Build();

            optionsBuilder.UseSqlServer(conf.GetConnectionString("SuiviDrones"));

            return new SuiviDronesContext(optionsBuilder.Options);
        }
        #endregion      
    }
}
