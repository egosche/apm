using System;
using apm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace apmTests
{
    [TestClass]
    public class KundenstammTests
    {
        [TestMethod]
        public void Kundenstamm_KonstruktorKorrekteEingabe_ErzeugtObjekt()
        {
            // Act
            Kundenstamm kundenstamm = new Kundenstamm("Delta Airlines");

            // Assert
            Assert.AreEqual("Delta Airlines", kundenstamm.Fluggesellschaft);
        }


        [TestMethod]
        public void Add_KorrekteEingabe_FuegtKundeHinzu()
        {
            // Arrange
            Kundenstamm kundenstamm = new Kundenstamm("Delta Airlines");
            Kunde kunde = new Kunde(1273856, "unbekannt", "Ikke", "Hüftgold", new DateTime(1976, 09, 17), 'm', 0157621823, "i.huefte@mallorca.es",
                    "deutsch", "Am Schwanenteich", "8", 09648, "Mittweida", "Deutschland");

            // Act
            kundenstamm.Add(kunde, 1273856.ToString());
        }
        

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_Duplikate_LiefertException()
        {
            // Arrange
            Kundenstamm kundenstamm = new Kundenstamm("Delta Airlines");
            Kunde kunde1 = new Kunde(1273856, "unbekannt", "Ikke", "Hüftgold", new DateTime(1976, 09, 17), 'm', 0157621823, "i.huefte@mallorca.es",
                    "deutsch", "Am Schwanenteich", "8", 09648, "Mittweida", "Deutschland");
            Kunde kunde2 = new Kunde(1273856, "unbekannt", "Ikke", "Hüftgold", new DateTime(1976, 09, 17), 'm', 01263812333, "i.huefte@mallorca.es",
                    "deutsch", "Am Schwanenteich", "8", 09648, "Mittweida", "Deutschland");

            // Act
            kundenstamm.Add(kunde1, 1273856.ToString());
            kundenstamm.Add(kunde2, 1273856.ToString());
        }
    }
}
