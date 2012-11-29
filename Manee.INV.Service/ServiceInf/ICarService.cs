using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;
namespace Manee.INV.Service.ServiceInf
{
    public interface ICarService
    {
        /// <summary>
        /// หารถทุกคันในระบบ
        /// </summary>
        List<Car> FindCarAll();
    }
}
