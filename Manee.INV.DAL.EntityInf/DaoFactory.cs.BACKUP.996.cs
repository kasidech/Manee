using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL.DAOImpl;

namespace Manee.INV.DAL
{
    public class DAOFactory
    {
        public static Object GetDao(String daoName)
        {
            if (daoName.Equals("DELIVERY_NOTE"))
            {
                IDeliveryNoteDAO dao = new DeliveryNoteDAOImpl();
                return dao;
            }
            else if (daoName.Equals("RECEIVE_NOTE"))
            {
                var dao = new ReceiveNoteDAOImpl();
                return dao;
            }
            else if(daoName.Equals("CAR"))
            {
                ICarDAO dao = new CarDAOImpl();
                return dao;
            }
<<<<<<< HEAD

            else if(daoName.Equals("NOTE_LINE_ITEM"))
            {
                INoteLineItemDAO dao = new NoteLineItemDAOImpl();
                return dao;
            }
=======
>>>>>>> c8cb932983c1b31cf327cc737cc79b872fc4d4c4
            else if (daoName.Equals("LOCATION"))
            {
                ILocationDAO dao = new LocationDAOImpl();
                return dao;
            }
            else
            {
                return null;
            }
        }
    }
}
