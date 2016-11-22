using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _DB_AG__Online_Kredit.Controllers
{
    public class FinanzielleSituationModel
    {

        public double NettoEinkommen { get; set; }

        public double Wohnkosten { get; set; }

        public double EinkünfteAlimenteUnterhalt { get; set; }

        public double UnterhaltsZahlungen { get; set; }

        public double Ratenverpflichtungen { get; set; }

        public int ID_Kunde { get; set; }
    }
}