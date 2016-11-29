using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _DB_AG__Online_Kredit.Models
{
    public class ArbeitgeberModel
    {

        public string ArbeitgeberName { get; set; }

        public int ID_BeschaeftigungsArt { get; set; }

        public int ID_Branche { get; set; }

        public string BeschäftigungSeit { get; set; }

        public int ID_Kunde { get; set; }
    }
}