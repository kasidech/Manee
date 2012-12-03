using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.Service.ServiceInf;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL;
using Manee.INV.DAL.Entity;

namespace Manee.INV.Service.ServiceInf
{
    public interface ILocationService
    {
        void CreateLocation(Location location);
        void Deletelocation(int location_Id);
        void UpdateLocation(Location location);
        List<Location> FindLocationAll();

    }
}
