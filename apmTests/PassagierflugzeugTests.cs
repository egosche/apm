using System;
using apm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace apmTests
{
    [TestClass]
    public class PassagierflugzeugTests
    {
        [TestMethod]
        public void Passagierflugzeug_KonstruktorKorrekteEingabe_ErzeugtObjekt()
        {
            // Act
            Passagierflugzeug passagierflugzeug = new Passagierflugzeug("OE-XEP");

            // Assert
            Assert.AreEqual("OE-XEP", passagierflugzeug.ID);
        }


        [TestMethod]
        public void Add_KorrekteEingabe_FuegtSitzHinzu()
        {
            // Arrange
            Passagierflugzeug passagierflugzeug = new Passagierflugzeug("OE-XEP");
            Sitzplatz sitz = new Sitzplatz("12a", "First Class");

            // Act
            passagierflugzeug.Add(sitz, "12a");
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_Duplikate_LiefertException()
        {
            // Arrange
            Passagierflugzeug passagierflugzeug = new Passagierflugzeug("OE-XEP");
            Sitzplatz sitz1 = new Sitzplatz("12a", "First Class");
            Sitzplatz sitz2 = new Sitzplatz("12a", "First Class");

            // Act
            passagierflugzeug.Add(sitz1, "12a");
            passagierflugzeug.Add(sitz2, "12a");
        }
    }
}
