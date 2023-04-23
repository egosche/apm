using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    /// <summary>
    /// Der Sitzplatz ist eine Komponente, welche einem Passagierflugzeug
    /// zugeorndet werden kann.
    /// </summary>
    public class Sitzplatz : IComponent
    {
        private ISite _curSitznummerSite;
        public event EventHandler Disposed;
        public string Sitznummer { get; set; }
        public string Befoerderungsklasse { get; set; }


        /// <summary>
        /// Konstruktor Sitzplatz
        /// </summary>
        /// <param name="sitznummer">Nummer, ueber welche der Sitzplatz eindeutig identifizierbar ist</param>
        /// <param name="befoerderungsklasse">Befoerderungsklasse, in welcher der Sitzplatz steht</param>
        public Sitzplatz(string sitznummer, string befoerderungsklasse)
        {
            this.Sitznummer = sitznummer;
            this.Befoerderungsklasse = befoerderungsklasse;
        }


        /// <summary>
        /// Entfernt ein Sitzplatzobjekt.
        /// </summary>
        public virtual void Dispose()
        {
            if (Disposed != null)
            {
                Disposed(this, EventArgs.Empty);
            }
        }


        /// <summary>
        /// Liefert bzw. setzt das Site Objekt
        /// </summary>
        public virtual ISite Site
        {
            get
            {
                return _curSitznummerSite;
            }
            set
            {
                _curSitznummerSite = value;
            }
        }


        /// <summary>
        /// Vergleich zwei Sitzplatzobjekte miteinander.
        /// </summary>
        /// <param name="cmp">Zu vergleichendes Sitzplatzobjekt</param>
        /// <returns></returns>
        public override bool Equals(object cmp)
        {
            Sitzplatz cmpObj = (Sitzplatz)cmp;
            if (this.Sitznummer.Equals(cmpObj.Sitznummer) && 
                this.Befoerderungsklasse.Equals(cmpObj.Befoerderungsklasse))
                return true;

            return false;
        }


        /// <summary>
        /// Liefert den HashCode des Sitzplatzobjektes.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
