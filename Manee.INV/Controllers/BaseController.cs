using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manee.INV.Controllers
{
    public class BaseController : System.Web.Mvc.Controller
    {
        protected IApplicationContext applicationContext;

        public BaseController()
        {
            applicationContext = new XmlApplicationContext("~/spring-inv-controller.xml");
        }

    }


}