using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _DB_AG__Online_Kredit.Controllers
{
    public class FinanzielleSituationModel
    {

        public double MonatsEinkommenNetto { get; set; }

        public double Wohnkosten { get; set; }

        public double EinkuenfteAlimenteUnterhalt { get; set; }

        public double AusgabenAlimenteUnterhalt { get; set; }

        public double Raten { get; set; }

        public int ID { get; set; }
    }
}