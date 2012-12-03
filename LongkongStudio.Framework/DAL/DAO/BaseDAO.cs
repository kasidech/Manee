using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LongkongStudio.Framework.DAL.DAO
{
    public abstract class BaseDAO
    {
        protected IApplicationContext appContext;
    }
}