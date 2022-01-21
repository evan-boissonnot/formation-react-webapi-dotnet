using SuiviDrones.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviDrones.API.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDeliveryRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Create(Delivery item);
    }
}
