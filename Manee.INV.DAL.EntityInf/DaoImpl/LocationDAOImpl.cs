using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL.DAOImpl;
using Manee.INV.DAL.Entity;

namespace Manee.INV.DAL.DAOImpl
{
    public class LocationDAOImpl :ILocationDAO
    {
        private ManeeDataContainer context = new ManeeDataContainer();

        void ILocationDAO.CreateLocation(Entity.Location item)
        {
            context.Locations.Add(item);
            context.SaveChanges();
        }

        void ILocationDAO.DeleteLocation(int id)
        {
            var location = context.Locations.FirstOrDefault(l => l.Id == id);
            context.Locations.Remove(location);
            context.SaveChanges();
        }

        Entity.Location ILocationDAO.FindLocationById(int id)
        {
           return context.Locations.FirstOrDefault(l => l.Id == id);
        }

        List<Entity.Location> ILocationDAO.FindLocationAll()
        {
            return new List<Location>();
        }

        List<Entity.Location> ILocationDAO.FindByCriteria(Location locationCriteria)
        {
            List<Entity.Location> resultList = new List<Location>();

            resultList = context.Locations.Where(
                l => (!string.IsNullOrEmpty(l.Code) && l.Code.Contains(locationCriteria.Code))
                     || (!string.IsNullOrEmpty(l.Name) && l.Name.Contains(locationCriteria.Name))
                     || (!string.IsNullOrEmpty(l.Address) && l.Address.Contains(locationCriteria.Address))
                     || (l.ProjectManagerId==locationCriteria.ProjectManagerId)
                     || (l.LocationType == locationCriteria.LocationType)
                     ).ToList();
            return resultList;

        }
    }
}
