using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace _DB_AG__Online_Kredit.BusinessLogic
{
    public class KreditVerwaltung
    {
            /// <summary>
            /// Erzeugt einen "leeren" dummy Kunden
            /// zu dem in Folge alle Konsumkredit Daten
            /// verknüpft werden können.
            /// </summary>
            /// <returns>einen leeren Kunden wenn erfolgreich, ansonsten null</returns>
            public static Kunde ErzeugeKunde()
            {
                Debug.WriteLine("KonsumKreditVerwaltung - ErzeugeKunde");
                Debug.Indent();

                Kunde newKunde = null;

                try
                {
                    using (var context = new dbKreditRechnerEntities())
                    {
                    newKunde = new BusinessLogic.Kunde()
                    {
                        Vorname = "anonym",
                        Nachname = "anonym",
                        Geschlecht = "w"
                        };
                        context.AlleKunden.Add(newKunde);

                        int anzahlZeilenBetroffen = context.SaveChanges();
                        Debug.WriteLine($"{anzahlZeilenBetroffen} Kunden angelegt!");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Fehler in ErzeugeKunde");
                    Debug.Indent();
                    Debug.WriteLine(ex.Message);
                    Debug.Unindent();
                    Debugger.Break();
                }

                Debug.Unindent();
                return newKunde;
            }

            /// <summary>
            /// Speichert zu einer übergebenene ID den Wunsch Kredit und dessen Laufzeit ab
            /// </summary>
            /// <param name="kreditBetrag">die Höhe des gewünschten Kredits</param>
            /// <param name="laufzeit">die Laufzeit des gewünschten Kredits</param>
            /// <param name="idKunde">die ID des Kunden zu dem die Angaben gespeichert werden sollen</param>
            /// <returns>true wenn Eintragung gespeichert werden konnte und der Kunde existiert, ansonsten false</returns>
            public static bool KreditSpeichern(double kreditBetrag, short laufzeit, int idKunde)
            {
                Debug.WriteLine("KonsumKreditVerwaltung - KreditSpeichern");
                Debug.Indent();

                bool erfolgreich = false;

                try
                {
                    using (var context = new dbKreditRechnerEntities())
                    {

                        /// speichere zum Kunden die Angaben
                        Kunde aktKunde = context.AlleKunden.Where(x => x.ID == idKunde).FirstOrDefault();

                        if (aktKunde != null)
                        {

                        Debug.WriteLine("KreditSpeichern: Create KreditWunsch");

                        KreditWunsch neuerKreditWunsch = new KreditWunsch()
                        {
                            Betrag = (decimal)kreditBetrag,
                            Laufzeit = laufzeit,
                            FKKunde = idKunde
                            };

                            context.AlleKreditWünsche.Add(neuerKreditWunsch);
                        }

                    Debug.WriteLine("KreditSpeichern: DBContextSave");
                    int anzahlZeilenBetroffen = context.SaveChanges();
                    Debug.WriteLine("KreditSpeichern: BoolchangeErfolgreich");
                    erfolgreich = anzahlZeilenBetroffen >= 1;
                    Debug.WriteLine($"{anzahlZeilenBetroffen} Kredit gespeichert!");
                }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Fehler in KreditSpeichern");
                    Debug.Indent();
                    Debug.WriteLine(ex.Message);
                    Debug.Unindent();
                    Debugger.Break();
                }

                Debug.Unindent();
                return erfolgreich;
            }





        public static bool FinanzielleSituationSpeichern(double nettoEinkommen, double ratenVerpflichtungen, double wohnkosten, double einkünfteAlimenteUnterhalt, double unterhaltsZahlungen, int idKunde)
            {
                Debug.WriteLine("KreditVerwaltung - FinanzielleSituationSpeichern");
                Debug.Indent();

                bool erfolgreich = false;

                try
                {
                    using (var context = new dbKreditRechnerEntities())
                    {

                        /// speichere zum Kunden die Angaben
                        Kunde aktKunde = context.AlleKunden.Where(x => x.ID == idKunde).FirstOrDefault();

                        if (aktKunde != null)
                        {
                            FinanzielleSituation neueFinanzielleSituation = new FinanzielleSituation()
                            {
                                MonatsEinkommenNetto = (decimal)nettoEinkommen,
                                AusgabenAlimenteUnterhalt = (decimal)unterhaltsZahlungen,
                                EinkuenfteAlimenteUnterhalt = (decimal)einkünfteAlimenteUnterhalt,
                                Wohnkosten = (decimal)wohnkosten,
                                Raten = (decimal)ratenVerpflichtungen,
                                ID = idKunde
                            };

                            context.AlleFinanzielleSituationen.Add(neueFinanzielleSituation);
                        }

                        int anzahlZeilenBetroffen = context.SaveChanges();
                        erfolgreich = anzahlZeilenBetroffen >= 1;
                        Debug.WriteLine($"{anzahlZeilenBetroffen} FinanzielleSituation gespeichert!");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Fehler in FinanzielleSituation");
                    Debug.Indent();
                    Debug.WriteLine(ex.Message);
                    Debug.Unindent();
                    Debugger.Break();
                }

                Debug.Unindent();
                return erfolgreich;
            }
        }
    
}