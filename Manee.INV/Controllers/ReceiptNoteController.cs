using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Manee.INV.Controllers
{
    public class ReceiptNoteController : Controller
    {
        //
        // GET: /ReceiptNote/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ReceiptNote/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ReceiptNote/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ReceiptNote/Create

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
        // GET: /ReceiptNote/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ReceiptNote/Edit/5

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
        // GET: /ReceiptNote/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ReceiptNote/Delete/5

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
