using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Manee.INV.DAL.Entity;
using Manee.INV.Service.ServiceInf;
using Manee.INV.Service;

namespace Manee.INV.Controllers
{
    public class ReceiveNoteController : Controller
    {
        private IReceiveNoteService iService = (IReceiveNoteService) ServiceFactory.GetService("RECEIVE_NOTE");  
        //
        // GET: /ReceiveNote/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ReceiveNote/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ReceiveNote/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ReceiveNote/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ReceiveNote/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ReceiveNote/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ReceiveNote/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ReceiveNote/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
