using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Manee.INV.Service.ServiceInf;
using Manee.INV.DAL.Entity;
using Manee.INV.Service;
using Manee.INV.Models;
using Newtonsoft.Json;
using LongkongStudio.Framework.Controllers;
using Spring.Context;
using Spring.Context.Support;
namespace Manee.INV.Controllers
{


    public class DeliveryNoteController : BaseController
    {
        public DeliveryNoteController()
        {
            appContext = ContextRegistry.GetContext();
        }


       // IDeliveryNoteService iservice =(IDeliveryNoteService)ServiceFactory.GetService("DELIVERY_NOTE");
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
            int location_Id = 2;
            NoteLineItem itemCriteria = new NoteLineItem();


<<<<<<< HEAD
            ICarService carService = (ICarService)applicationContext.GetObject("CarSrv");
            IDeliveryNoteService service = (IDeliveryNoteService)applicationContext.GetObject("DeliveryNoteSrv");
            INoteLineItemService nliService = (INoteLineItemService)applicationContext.GetObject("NoteLineItemSrv");
            ViewData["cars"] = carService.FindCarAll().ToString();
=======

            ICarService carSrv = (ICarService)appContext.GetObject("CarSrv");
            IDeliveryNoteService service = (IDeliveryNoteService)appContext.GetObject("DeliveryNoteSrv");
            INoteLineItemService nliService = (INoteLineItemService)appContext.GetObject("NoteLineItemSrv");
            ViewData["cars"] = carSrv.FindCarAll();
>>>>>>> 16febd4f8be98335fd4a3a09f46a344891c168c4
            ViewData["NoteLineItem"] = nliService.FindNoteLineItemByLocation(location_Id);
         
            return View();
        }

        //
        // POST: /DeliveryNote/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection, string deliveryNoteItemJson)
        {

            IDeliveryNoteService DeliveryNoteSrv= (IDeliveryNoteService)appContext.GetObject("NoteLineItemSrv");
            INoteLineItemService NoteLineItemSrv=(INoteLineItemService)appContext.GetObject("NoteLineItemSrv");


            var submittedDntItems = deliveryNoteItemJson == "" ? new List<NoteLineItem>() : JsonConvert.DeserializeObject<IList<NoteLineItem>>(deliveryNoteItemJson);

            
            int deliveryNoteId = Convert.ToInt32( collection["DeliveryNoteId"]);
            int destinationId = Convert.ToInt32(collection["DestinationId"]); 


            try
            {
                if (!string.IsNullOrEmpty(collection["DeliveryNoteId"]) && (!string.IsNullOrEmpty(collection["DestinationId"])))
                {
                    foreach(NoteLineItem item in submittedDntItems){
                        int itemId = (int)item.Id;
                        DeliveryNoteSrv.SetStatusToItem(deliveryNoteId, destinationId);
                    }
                }
                DeliveryNote note = new DeliveryNote();
                note.SenderName = collection["senderName"];
                
                // TODO: Add insert logic here
                //service.CreateDeliveryNote(note);
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
            IDeliveryNoteService service = (IDeliveryNoteService)appContext.GetObject("DeliveryNoteService");
            
            DeliveryNote Data = service.FindDeliveryNoteById(id);
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
