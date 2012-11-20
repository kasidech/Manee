﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Manee.INV.Service.DeliveryNoteService;


namespace Manee.INV.Controllers
{
    public class DeliveryNoteController : Controller
    {
        //
        // GET: /DeliveryNote/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /DeliveryNote/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DeliveryNote/Create

        public ActionResult Create()
        {
            DeliveryNoteService delSer = new DeliveryNoteService();
            delSer.CreateDeliveryNote();
            
            return View();
        }

        //
        // POST: /DeliveryNote/Create

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
        // GET: /DeliveryNote/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DeliveryNote/Edit/5

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
        // GET: /DeliveryNote/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DeliveryNote/Delete/5

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
