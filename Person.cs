using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    /// <summary>
    /// Abstrakte Klasse einer Person.
    /// </summary>
    public abstract class Person
    {
        // Definition, Get und Set fuer die einzelnen Attribute einer Person
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public enum Geschlechter { m, w, d }
        public Geschlechter Geschlecht { get; set; }
        public long Telefonnummer { get; set; }
        public string EMailAdresse { get; set; }
        public string Staatsbuergerschaft { get; set; }
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public int Zip { get; set; }
        public string Wohnort { get; set; }
        public string Land { get; set; }

    }
}
