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

        //}

        //    public ActionResult FinanzielleSituation()
        //    {
        //        FinanzielleSituationModel model = new FinanzielleSituationModel()
        //        {
        //            ID_Knde = int.Parse(TempData["idKunde"].ToString())
        //        };

        //        return View();

        //    }


        //    public ActionResult Finanzielle Situation(FinanzielleSituationModel model)
        //    {

        //        if (ModelState.IsValid)
        //        {
        //            if (KreditVerwaltung.FinanzielleSituationSpeichern(model.NettoEinkommen, model.RatenVerpflichtungen, model.Wohnkosten, model.EinküfteAlimenteUnterhalt, model.Unterhaltszahlungen, model.ID_Kunde))
        //            {

        //                TempData["idKunde"] = model.ID_Kunde;
        //                return RedirectToAction("PersönlicheDaten");
        //            }
        //        }

        //        return View();

        //    }


        //    public ActionResult PersönlicheDaten()
        //    {

        //        PersönlicheDatenModel model = new PersönlicheDatenModel()
        //        {
        //            ID_Kunde = int.Parse(TempData["idKunde"].ToString())

        //        };

        //        return View();
        //    }


        //    public ActionResult PersönlicheDaten(PersönlicheDatenModel model)
        //    {
        //        return View();
        //    }

        //    public ActionResult Arbeitgeber()
        //    {
        //        return View();
        //    }

        //    public ActionResult Arbeitgeber(ArbeitgeberModel model)
        //    {
        //        return View();
        //    }

        //    public ActionResult KontoInformationen()
        //    {
        //        return View();
        //    }

        //    public ActionResult KontoInformationen(KontoInformationenModel model)
        //    {
        //        return View();
        //    }

        //    public ActionResult Zusammenfassung()
        //    {
        //        return View();
        //    }

        //    public ActionResult Zusammenfassung(ZusammenfassungModel model)
        //    {
        //        return View();
        //    }

        //}
    }