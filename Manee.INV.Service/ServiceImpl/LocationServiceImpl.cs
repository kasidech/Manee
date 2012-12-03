using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.Service.ServiceInf;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL;
using Manee.INV.DAL.Entity;

namespace Manee.INV.Service.ServiceImpl
{
    class LocationServiceImpl : ILocationService
    {
        ILocationDAO locationDAO = (ILocationDAO)DAOFactory.GetDao("LOCATION"); 

        public void CreateLocation(Location location)
        {
            locationDAO.CreateLocation(location);
        }

        public void Deletelocation(int location_Id)
        {
            locationDAO.DeleteLocation(location_Id);
        }

        public void UpdateLocation(Location location)
        {
            throw new NotImplementedException();
        }

        public List<Location> FindLocationAll()
        {
            
            List<Location> result = locationDAO.FindLocationAll();
            return result;
        }
    }
}
