using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    /// <summary>
    /// Site Interface wird benutzt, um Sitzplaetze an Passagierflugzeuge 
    /// zu binden und eine Kommunikation zwischen beiden zu ermoeglichen.
    /// </summary>
    class SitznummerSite : ISite
    {
        private IComponent _curComponent;
        private IContainer _curContainer;
        private bool _bDesignMode;
        private string _sitznummerName;



        /// <summary>
        /// Konstruktor SitznummerSite
        /// </summary>
        /// <param name="actvCntr"></param>
        /// <param name="prntCmpnt"></param>
        public SitznummerSite(IContainer actvCntr, IComponent prntCmpnt)
        {
            _curComponent = prntCmpnt;
            _curContainer = actvCntr;
            _bDesignMode = false;
            _sitznummerName = null;
        }


        /// <summary>
        /// Liefert die zugehoriege Komponente der SitznummerSite.
        /// </summary>
        public virtual IComponent Component
        {
            get
            {
                return _curComponent;
            }
        }


        /// <summary>
        /// Liefert den zugehoerigen Container der SitznnummerSite.
        /// </summary>
        public virtual IContainer Container
        {
            get
            {
                return _curContainer;
            }
        }


        /// <summary>
        /// Liefert den DesignMode der Site.
        /// </summary>
        public virtual bool DesignMode
        {
            get
            {
                return _bDesignMode;
            }
        }


        /// <summary>
        /// Liefert bzw. setzt den Namen der Site.
        /// Der Name (Sitznummer) wird stets als String behandelt.
        /// </summary>
        public virtual string Name
        {
            get
            {
                return _sitznummerName;
            }

            set
            {
                _sitznummerName = value;
            }
        }


        /// <summary>
        /// Liefert das Service Objekt der Site.
        /// Service Objekte werden in diesem Programm nicht verwendet.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public virtual object GetService(Type serviceType)
        {
            return null;
        }
    }
}
