using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;

namespace DAL.Services
{
    public class BaseService
    {
       protected TOCPPEntities db = new TOCPPEntities();
    }
}
