using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    /// <summary>
    /// Fluggesellschaft.
    /// </summary>
    public class Fluggesellschaft
    {

        public string Bezeichnung { get; set; }
        public string IataCode { get; set; }

        public Fluggesellschaft(string iataCode, string bezeichnung)
        {
            IataCode = iataCode;
            Bezeichnung = bezeichnung;
        }

    }

}
