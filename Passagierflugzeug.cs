using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    /// <summary>
    /// Das Passagierflugzeug ist die Containerklasse, welche die
    /// verschiedenen Sitzplaetze beinhaltet. Die Klasse erbt vom 
    /// Flugzeug.
    /// </summary>
    public class Passagierflugzeug : Flugzeug, IDisposable, IContainer
    {
        private ArrayList _sitzplatzList;
        public int Kapazität { get; set; }


        /// <summary>
        /// Konstruktor Passagierflugzeug
        /// </summary>
        /// <param name="id">Luftfahrzeugkennzeichen</param>
        public Passagierflugzeug(string id)
        {
            _sitzplatzList = new ArrayList();
            this.ID = id;
        }


        /// <summary>
        /// Sitzplatz zu einem Passagierflugzeug hinzufuegen.
        /// Der Sitzplatz wird ohne Erstellung eines SitznummerSite Objektes hinzugefuegt.
        /// Diese Methode ueberprueft keine Duplikate und sollte daher nicht verwendet
        /// werden.
        /// </summary>
        /// <param name="sitzplatz"></param>
        public virtual void Add(IComponent sitzplatz)
        {
            _sitzplatzList.Add(sitzplatz);
        }

        /// <summary>
        /// Sitzplatz zu einem Passagierflugzeug hinzufuegen.
        /// Der Sitzplatz wird anhand des SitznummerSite Objektes hinzugefuegt.
        /// </summary>
        /// <param name="sitzplatz">Sitzplatzobjekt, welches zum Passagierflugzeug hinzugefuegt werden soll.</param>
        /// <param name="sitznummer">Sitznummer, welche den Sitzplatz eindeutig identifiziert.</param>
        public virtual void Add(IComponent sitzplatz, string sitznummer)
        {
            for (int i = 0; i < _sitzplatzList.Count; ++i)
            {
                IComponent curObj = (IComponent)_sitzplatzList[i];
                if (curObj.Site != null)
                {
                    if (curObj.Site.Name.Equals(sitznummer))
                        throw new ArgumentException("Diese Sitznummer existiert bereits im Passagierflugzeug.");
                }
            }

            SitznummerSite data = new SitznummerSite(this, sitzplatz);
            data.Name = sitznummer;
            sitzplatz.Site = data;
            _sitzplatzList.Add(sitzplatz);
        }

        /// <summary>
        /// Entfernt einen Sitzplatz aus dem Passagierflugzeug.
        /// </summary>
        /// <param name="sitzplatz">Sitzplatz, welcher entfernt werden soll.</param>
        public virtual void Remove(IComponent sitzplatz)
        {
            for (int i = 0; i < _sitzplatzList.Count; ++i)
            {
                if (sitzplatz.Equals(_sitzplatzList[i]))
                {
                    _sitzplatzList.RemoveAt(i);
                    break;
                }
            }
        }


        /// <summary>
        /// Liefert eine ComponentCollection, welche die einzelnen Sitzplaetze beinhaltet.
        /// </summary>
        public ComponentCollection Components
        {
            get
            {
                IComponent[] datalist = new Sitzplatz[_sitzplatzList.Count];
                _sitzplatzList.CopyTo(datalist);
                return new ComponentCollection(datalist);
            }
        }


        /// <summary>
        /// Loest das Passagierflugzeug und die darin befindlichen Sitzplaetz auf.
        /// </summary>
        public virtual void Dispose()
        {
            for (int i = 0; i < _sitzplatzList.Count; ++i)
            {
                IComponent curObj = (IComponent)_sitzplatzList[i];
                curObj.Dispose();
            }

            _sitzplatzList.Clear();
        }
    }
}
