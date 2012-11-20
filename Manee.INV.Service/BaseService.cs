using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Manee.INV.Service
{
    public class BaseService
    {
        protected TOCPPEntities db = new TOCPPEntities(); 
    }
}
