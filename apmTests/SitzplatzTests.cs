using System;
using apm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace apmTests
{
    [TestClass]
    public class SitzplatzTests
    {
        [TestMethod]
        public void Sitzplatz_KonstruktorKorrekteEingabe_ErzeugtObjekt()
        {
            // Act
            Sitzplatz sitz = new Sitzplatz("12a", "First Class");

            // Assert
            Assert.AreEqual("12a", sitz.Sitznummer);
            Assert.AreEqual("First Class", sitz.Befoerderungsklasse);
        }


        [TestMethod]
        public void Equals_ZweiGleicheSitze_LiefertTrue()
        {
            // Arrange
            Sitzplatz sitz1 = new Sitzplatz("12a", "First Class");
            Sitzplatz sitz2 = new Sitzplatz("12a", "First Class");

            // Act
            bool result = sitz1.Equals(sitz2);

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void Equals_ZweiUnterschiedlicheSitze_LiefertFalse()
        {
            // Arrange
            Sitzplatz sitz1 = new Sitzplatz("12a", "First Class");
            Sitzplatz sitz2 = new Sitzplatz("12b", "First Class");

            // Act
            bool result = sitz1.Equals(sitz2);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
