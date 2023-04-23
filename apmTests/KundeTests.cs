using System;
using apm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace apmTests
{
    [TestClass]
    public class KundeTests
    {
        [TestMethod]
        public void Kunde_KonstruktorKorrekteEingabe_ErzeugtObjekt()
        {
            // Act
            Kunde kunde = new Kunde(1273856, "unbekannt", "Ikke", "Hüftgold", new DateTime(1976, 09, 17), 'm', 0157621823, "i.huefte@mallorca.es",
                    "deutsch", "Am Schwanenteich", "8", 09648, "Mittweida", "Deutschland");

            // Assert
            Assert.AreEqual(1273856, kunde.Kundennummer);
            Assert.AreEqual("unbekannt", kunde.Status);
            Assert.AreEqual("Ikke", kunde.Vorname);
            Assert.AreEqual("Hüftgold", kunde.Nachname);
            Assert.AreEqual(new DateTime(1976, 09, 17), kunde.Geburtsdatum);
            Assert.AreEqual('m', kunde.Geschlecht);
            Assert.AreEqual(0157621823, kunde.Telefonnummer);
            Assert.AreEqual("i.huefte@mallorca.es", kunde.EMailAdresse);
            Assert.AreEqual("deutsch", kunde.Staatsbuergerschaft);
            Assert.AreEqual("Am Schwanenteich", kunde.Strasse);
            Assert.AreEqual("8", kunde.Hausnummer);
            Assert.AreEqual(09648, kunde.Zip);
            Assert.AreEqual("Mittweida", kunde.Wohnort);
            Assert.AreEqual("Deutschland", kunde.Land);
        }
    }
}
