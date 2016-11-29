using _DB_AG__Online_Kredit.BusinessLogic;
using _DB_AG__Online_Kredit.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _DB_AG__Online_Kredit.Controllers
{
    public class KreditController : Controller
    {
        [HttpGet]
        // GET: Kredit
        public ActionResult KreditRechner()
        {
            Debug.WriteLine("HttpGet: Kredit/KreditRechner");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KreditRechner(KreditRechnerModel model)
        {
            Debug.WriteLine("HttpPost: Kredit/KreditRechner");

            if (ModelState.IsValid)
            {
                Kunde newKunde = KreditVerwaltung.ErzeugeKunde();

                if (newKunde != null && KreditVerwaltung.KreditSpeichern(model.KreditBetrag, model.Laufzeit, newKunde.ID))
                {
                    Response.Cookies.Add(new HttpCookie("id", newKunde.ID.ToString()));
                    return RedirectToAction("FinanzielleSituation");
                }
            }

            return View(model);

        }

        [HttpGet]
        public ActionResult FinanzielleSituation()
        {
            Debug.WriteLine("HttpGet: Kredit/FinanzielleSituation");

            FinanzielleSituationModel model = new FinanzielleSituationModel()
            {
                ID_Kunde = int.Parse(Request.Cookies["id"].Value)
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FinanzielleSituation(FinanzielleSituationModel model)
        {

            Debug.WriteLine("HttpPost: Kredit/FinanzielleSituation");

            if (ModelState.IsValid)
            {
                /// speichere Daten über BusinessLogic
                if (KreditVerwaltung.FinanzielleSituationSpeichern(
                                                model.MonatsEinkommenNetto,
                                                model.Raten,
                                                model.Wohnkosten,
                                                model.EinkuenfteAlimenteUnterhalt,
                                                model.AusgabenAlimenteUnterhalt,
                                                model.ID_Kunde))
                {
                    return RedirectToAction("Arbeitgeber");
                }
            }

            return View(model);
        }


        [HttpGet]
        public ActionResult Arbeitgeber()
        {
            Debug.WriteLine("GET - KonsumKredit - Arbeitgeber");

            //List<BeschaeftigungsArtModel> alleBeschaeftigungen = new List<BeschaeftigungsArtModel>();
            //List<BrancheModel> alleBranchen = new List<BrancheModel>();

            //foreach (var branche in KreditVerwaltung.BranchenLaden())
            //{
            //    alleBranchen.Add(new BrancheModel()
            //    {
            //        ID = branche.ID.ToString(),
            //        Bezeichnung = branche.Bezeichnung
            //    });
            //}

            //foreach (var beschaeftigungsArt in KreditVerwaltung.BeschaeftigungsArtenLaden())
            //{
            //    alleBeschaeftigungen.Add(new BeschaeftigungsArtModel()
            //    {
            //        ID = beschaeftigungsArt.ID.ToString(),
            //        Bezeichnung = beschaeftigungsArt.Bezeichnung
            //    });
            //}

            ArbeitgeberModel model = new ArbeitgeberModel()
            {
                //AlleBeschaeftigungen = alleBeschaeftigungen,
                //AlleBranchen = alleBranchen,
                ID_Kunde = int.Parse(Request.Cookies["idKunde"].Value)
            };

            return View(model);

        }

        [HttpPost]
        public ActionResult Arbeitgeber(ArbeitgeberModel model)
        {
            return View();
        }

        public ActionResult KontoInformationen()
        {
            return View();
        }


        [HttpGet]
        public ActionResult PersönlicheDaten()
        {

            PersönlicheDatenModel model = new PersönlicheDatenModel()
            {
                ID_Kunde = int.Parse(TempData["id"].ToString())

            };

            return View();
        }

        [HttpPost]
        public ActionResult PersönlicheDaten(PersönlicheDatenModel model)
        {
            return View();
        }


        //public ActionResult KontoInformationen(KontoInformationenModel model)
        //{
        //    return View();
        //}

        public ActionResult Zusammenfassung()
        {
            return View();
        }

        //public ActionResult Zusammenfassung(ZusammenfassungModel model)
        //{
        //    return View();
        //}

    }
}