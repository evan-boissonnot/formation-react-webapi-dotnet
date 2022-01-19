using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.API.Models
{
    public class Drone
    {
        private int _id;

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Matricule { get; set; }
        #endregion
    }
}
