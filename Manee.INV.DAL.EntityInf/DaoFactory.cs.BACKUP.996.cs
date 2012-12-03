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


            else if(daoName.Equals("NOTE_LINE_ITEM"))
            {
                INoteLineItemDAO dao = new NoteLineItemDAOImpl();
                return dao;
            }

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
