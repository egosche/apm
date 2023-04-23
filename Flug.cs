using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    /// <summary>
    /// Flug.
    /// </summary>
    public class Flug
    {
        public int Flugnummer { get; set; }
        public string StartFlughafenCode { get; set; }
        public string ZielFlughafenCode { get; set; }
        public DateTime StartZeitpunkt { get; set; }
        public DateTime LandZeitpunkt { get; set; }


        /// <summary>
        /// Standard-Konstruktor Flug
        /// </summary>
        /// <param name="flugnummer">Nummer, anhand ein Flug eindeutig identifiziert werden kann</param>
        public Flug(int flugnummer)
        {
            this.Flugnummer = flugnummer;
        }


        /// <summary>
        /// Erweiterter Konstruktor Flug
        /// </summary>
        /// <param name="flugnummer">Nummer, anhand ein Flug eindeutig identifiziert werden kann</param>
        /// <param name="startFlughafenCode">IATA-Code des Startflughafen</param>
        /// <param name="zielFlughafenCode">IATA-Code des Zielflughafen</param>
        public Flug(int flugnummer, string startFlughafenCode, string zielFlughafenCode)
        {
            this.Flugnummer = flugnummer;
            this.StartFlughafenCode = startFlughafenCode;
            this.ZielFlughafenCode = zielFlughafenCode;
        }


        /// <summary>
        /// Vollstaendiger Konstruktor Flug
        /// </summary>
        /// <param name="flugnummer">Nummer, anhand ein Flug eindeutig identifiziert werden kann</param>
        /// <param name="startFlughafenCode">IATA-Code des Startflughafen</param>
        /// <param name="zielFlughafenCode">IATA-Code des Zielflughafen</param>
        /// <param name="startZeitpunkt">Zeitpunkt, zu welchem das Flugzeug startet bzw. starten soll</param>
        /// <param name="landeZeitpunkt">Zeitpunkt, zu welchem das Flugzeug gelandet ist bzw. landen soll</param>
        public Flug(int flugnummer, string startFlughafenCode, string zielFlughafenCode, 
            DateTime startZeitpunkt, DateTime landeZeitpunkt)
        {
            this.Flugnummer = flugnummer;
            this.StartFlughafenCode = startFlughafenCode;
            this.ZielFlughafenCode = zielFlughafenCode;
            this.StartZeitpunkt = startZeitpunkt;
            this.LandZeitpunkt = landeZeitpunkt;
        }


        /// <summary>
        /// Liefert die Flugdauer eines Fluges. Befindet sich der Start zeitlich gesehen 
        /// nach der Landung, wird eine Exception ausgeloest.
        /// </summary>
        /// <returns>Zeitspanne des Fluges im Format DAYS.HOURS:MINUTES:SECOUNDS</returns>
        public TimeSpan GetFlugdauer()
        {
            if (LandZeitpunkt.Subtract(StartZeitpunkt) < new TimeSpan(0))
                throw new ArgumentException();
            return LandZeitpunkt.Subtract(StartZeitpunkt);
        }
    }
}
