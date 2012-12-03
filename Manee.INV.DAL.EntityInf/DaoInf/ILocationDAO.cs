using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;
using Manee.INV.DAL.DAOInf;


namespace Manee.INV.DAL.DAOInf
{
   public interface ILocationDAO
    {
        void CreateLocation(Location location);
        void DeleteLocation(int id);
        void UpdateLocation(Location location); 
        List<Location> FindLocationAll();

              
    }
}
