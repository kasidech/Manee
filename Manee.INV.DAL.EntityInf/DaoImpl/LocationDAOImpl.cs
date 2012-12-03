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


        List<Entity.Location> ILocationDAO.FindLocationAll()
        {
            return context.Locations.ToList();
        }





    }
}
