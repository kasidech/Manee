using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Manee.INV.Service.ServiceInf;
using Manee.INV.DAL.Entity;
using Manee.INV.Service;
using Manee.INV.Models;



namespace Manee.INV.Controllers
{
    public class DeliveryNoteController : Controller
    {
        IDeliveryNoteService iservice =(IDeliveryNoteService)ServiceFactory.GetService("DELIVERY_NOTE");
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
          
            return View();
        }

        //
        // POST: /DeliveryNote/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection, string deliveryNoteItemJson)
        {
            var d = collection["InputGrid"];
            try
            {
                DeliveryNote note = new DeliveryNote();
                note.SenderName = collection["senderName"];
                
                // TODO: Add insert logic here
                iservice.CreateDeliveryNote(note);
                return View();
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
            
            DeliveryNote Data = iservice.FindDeliveryNoteById(id);
            DeliveryNoteViewModel viewData = new DeliveryNoteViewModel();
            viewData.DeliveryNote = Data;
            return View(viewData);
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
