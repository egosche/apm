using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    /// <summary>
    /// Abstrakte Klasse eines Flugzeuges.
    /// </summary>
    public abstract class Flugzeug
    {
        public string ID { get; set; }
        public string Hersteller { get; set; }
        public string Bezeichnung { get; set; }
    }
}
