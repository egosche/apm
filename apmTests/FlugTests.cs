using System;
using apm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace apmTests
{
    [TestClass]
    public class FlugTests
    {
        [TestMethod]
        public void Flug_VollstaendigerKonstruktorKorrekteEingabe_ErzeugtObjekt()
        {
            // Act
            Flug flug = new Flug(1234, "FRA", "CDG", new DateTime(2020, 09, 25, 19, 25, 00), new DateTime(2020, 09, 25, 20, 54, 00));

            // Assert
            Assert.AreEqual(1234, flug.Flugnummer);
            Assert.AreEqual("FRA", flug.StartFlughafenCode);
            Assert.AreEqual("CDG", flug.ZielFlughafenCode);
            Assert.AreEqual(new DateTime(2020, 09, 25, 19, 25, 00), flug.StartZeitpunkt);
            Assert.AreEqual(new DateTime(2020, 09, 25, 20, 54, 00), flug.LandZeitpunkt);
        }

        
        [TestMethod]
        public void GetFlugdauerTests_startZeitpunktVorlandeZeitpunkt_LiefertZeitspanne()
        {
            // Arrange
            Flug flug = new Flug(1234, "FRA", "CDG", new DateTime(2020, 09, 25, 19, 25, 00), new DateTime(2020, 09, 25, 20, 54, 00));

            // Act 
            TimeSpan result = flug.GetFlugdauer();

            // Assert
            Assert.AreEqual(new TimeSpan(1, 29, 0), result);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFlugdauerTests_startZeitpunktNachlandeZeitpunkt_LiefertException()
        {
            // Arrange
            Flug flug = new Flug(1234, "FRA", "CDG", new DateTime(2020, 09, 25, 19, 25, 00), new DateTime(2020, 09, 25, 18, 54, 00));

            // Act 
            TimeSpan result = flug.GetFlugdauer();
        }
    }
}
