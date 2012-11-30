using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Manee.INV.Service.ServiceInf;
using Manee.INV.Service;
using LongkongStudio.Framework.Controllers;

namespace Manee.INV.Controllers
{
    public class NoteLineItemController : BaseController
    {
        //
        // GET: /NoteLineItem/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /NoteLineItem/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /NoteLineItem/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /NoteLineItem/Create

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
        // GET: /NoteLineItem/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /NoteLineItem/Edit/5

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
        // GET: /NoteLineItem/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /NoteLineItem/Delete/5

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
