using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace LongkongStudio.Framework.Controllers
{
    public abstract class BaseController : System.Web.Mvc.Controller
    {
        protected IApplicationContext appContext;

        
    }


}