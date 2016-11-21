using _DB_AG__Online_Kredit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _DB_AG__Online_Kredit.Controllers
{
    public class KreditController : Controller
    {
        // GET: Kredit
        public ActionResult KreditRechner()
        {
            return View();
        }


        //public ActionResult KreditRechner(KreditRechnerModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        /// Kunde newKunde = Krediterwaltung.ErzeugeKunde();
        //        /// 
        //        ///if ( newKunde != null && KreditVerwaltung.KreditSpeichern(model.KreditBetrag, model.Laufzeit, newKunde.ID))
        //        ///{
        //        ///TempData["idKunde] = neuerKunde.ID;
        //        ///return RedirectToAction("FinanzielleSituation");
        //    }
        //}

        //return View();

    }
}