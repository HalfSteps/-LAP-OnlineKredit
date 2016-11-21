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


        public ActionResult KreditRechner(KreditRechnerModel model)
        {
            if (ModelState.IsValid)
            {
                Kunde new
            }
        }

    }
}