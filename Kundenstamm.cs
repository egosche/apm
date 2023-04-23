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
    /// Der Kundenstamm ist die Containerklasse, welche die Kunden der 
    /// verschiedenen Fluggesellschaften beinhaltet.
    /// </summary>
    public class Kundenstamm : IDisposable, IContainer
    {
        private ArrayList _kundenList;
        public string Fluggesellschaft { get; set; }


        /// <summary>
        /// Konstruktor Kundenstamm.
        /// </summary>
        /// <param name="fluggesellschaft">Name der Fluggesellschaft, welche diese Kundenstamm besitzt.</param>
        public Kundenstamm(string fluggesellschaft)
        {
            _kundenList = new ArrayList();
            this.Fluggesellschaft = fluggesellschaft;
        }


        /// <summary>
        /// Kunde zu einem Kundenstamm hinzufuegen.
        /// Der Kunde wird ohne Erstellung eines KundennummerSite Objektes hinzugefuegt.
        /// Diese Methode ueberprueft keine Duplikate und sollte daher nicht verwendet
        /// werden.
        /// </summary>
        /// <param name="kunde">Kundenobjekt, welches zum Kundenstamm hinzugefuegt werden soll.</param>
        public virtual void Add(IComponent kunde)
        {
            _kundenList.Add(kunde);
        }


        /// <summary>
        /// Kunde zu einem Kundenstamm hinzufuegen.
        /// Der Kunde wird anhand des KundennummerSite Objektes hinzugefuegt.
        /// </summary>
        /// <param name="kunde">Kundenobjekt, welches zum Kundenstamm hinzugefuegt werden soll.</param>
        /// <param name="kundennummer">Kundennummer, welche den Kunden eindeutig identifiziert.</param>
        public virtual void Add(IComponent kunde, string kundennummer)
        {
            for (int i = 0; i < _kundenList.Count; ++i)
            {
                IComponent curObj = (IComponent)_kundenList[i];
                if (curObj.Site != null)
                {
                    if (curObj.Site.Name.Equals(kundennummer))
                        throw new ArgumentException("Diese Kundennummer existiert bereits im Kundenstamm.");
                }
            }

            KundennummerSite data = new KundennummerSite(this, kunde);
            data.Name = kundennummer;
            kunde.Site = data;
            _kundenList.Add(kunde);
        }


        /// <summary>
        /// Entfernt einen Kunden aus der Fluggesellschaft
        /// </summary>
        /// <param name="kunde">Kunde, welcher entfernt werden soll.</param>
        public virtual void Remove(IComponent kunde)
        {
            for (int i = 0; i < _kundenList.Count; ++i)
            {
                if (kunde.Equals(_kundenList[i]))
                {
                    _kundenList.RemoveAt(i);
                    break;
                }
            }
        }


        /// <summary>
        /// Liefert eine ComponentCollection, welche die einzelnen Kunden beinhaltet.
        /// </summary>
        public ComponentCollection Components
        {
            get
            {
                IComponent[] datalist = new Kunde[_kundenList.Count];
                _kundenList.CopyTo(datalist);
                return new ComponentCollection(datalist);
            }
        }


        /// <summary>
        /// Loest den Kundenstamm und die darin befindlichen Kunden auf.
        /// </summary>
        public virtual void Dispose()
        {
            for (int i = 0; i < _kundenList.Count; ++i)
            { 
                IComponent curObj = (IComponent)_kundenList[i];
                curObj.Dispose();
            }

            _kundenList.Clear();
        }
    }
}
