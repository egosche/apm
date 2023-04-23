using System;
using apm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace apmTests
{
    [TestClass]
    public class FluggesellschaftTests
    {
        [TestMethod]
        public void Fluggesellschaft_KorrekteEingabe_ErzeugtObjekt()
        {
            // Act
            Fluggesellschaft fluggesellschaft = new Fluggesellschaft("KL", "KLM Royal Dutch Airlines");

            // Assert
            Assert.AreEqual("KL", fluggesellschaft.IataCode);
            Assert.AreEqual("KLM Royal Dutch Airlines", fluggesellschaft.Bezeichnung);
        }
    
    }
}
