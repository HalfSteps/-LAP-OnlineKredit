//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _DB_AG__Online_Kredit.BusinessLogic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kunde
    {
        public int ID { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Geschlecht { get; set; }
        public System.DateTime Geburtsdatum { get; set; }
        public Nullable<int> FKTitel { get; set; }
        public Nullable<int> FKFamilienstand { get; set; }
        public string FKStaatsangehoerigkeit { get; set; }
        public Nullable<int> FKWohnart { get; set; }
        public Nullable<int> FKSchulabschluss { get; set; }
        public string IdentifikationsNummer { get; set; }
        public Nullable<int> FKIdentifikationsArt { get; set; }
    
        public virtual Arbeitgeber Arbeitgeber { get; set; }
        public virtual Familienstand Familienstand { get; set; }
        public virtual FinanzielleSituation FinanzielleSituation { get; set; }
        public virtual IdentifikationsArt IdentifikationsArt { get; set; }
        public virtual KontaktDaten KontaktDaten { get; set; }
        public virtual KontoDaten KontoDaten { get; set; }
        public virtual KreditWunsch KreditWunsch { get; set; }
        public virtual Schulabschluss Schulabschluss { get; set; }
        public virtual Land Staatsangehoerigkeit { get; set; }
        public virtual Titel Titel { get; set; }
        public virtual Wohnart Wohnart { get; set; }
    }
}
