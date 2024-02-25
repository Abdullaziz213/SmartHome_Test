using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_SmartHome.Test
{
    [TestClass]
    public class MarkisensteuerungTest
    {
        [TestMethod]
        public void MarkisenOffenZimmer20_Aussen19_Wind25()
        {

            var wettersensorMock = new WettersensorMock(20, false, 25);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wintergarten", 19);
            

            wohnung.GenerateWetterdaten();

            var wintergarten = (Markisensteuerung)wohnung.GetZimmer("Wintergarten");
            Assert.IsTrue(wintergarten.markiseEingefahren);
        }
        [TestMethod]
        public void MarkisenZuZimmer20_Aussen19_Wind32()
        {

            var wettersensorMock = new WettersensorMock(20, false, 32);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wintergarten", 19);


            wohnung.GenerateWetterdaten();

            var wintergarten = (Markisensteuerung)wohnung.GetZimmer("Wintergarten");
            Assert.IsFalse(wintergarten.markiseEingefahren);
        }
        [TestMethod]
        public void MarkisenZuZimmer14_Aussen20_Wind20()
        {

            var wettersensorMock = new WettersensorMock(14, false, 20);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wintergarten", 20);


            wohnung.GenerateWetterdaten();

            var wintergarten = (Markisensteuerung)wohnung.GetZimmer("Wintergarten");
            Assert.IsFalse(wintergarten.markiseEingefahren);
        }
        [TestMethod]
        public void MarkisenOffenZimmer16_Aussen15_Wind29()
        {

            var wettersensorMock = new WettersensorMock(16, false, 29);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wintergarten", 15);


            wohnung.GenerateWetterdaten();

            var wintergarten = (Markisensteuerung)wohnung.GetZimmer("Wintergarten");
            Assert.IsTrue(wintergarten.markiseEingefahren);
        }
        [TestMethod]
        public void MarkisenZuZimmer16_Aussen15_Wind31()
        {

            var wettersensorMock = new WettersensorMock(16, false, 31);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wintergarten", 15);


            wohnung.GenerateWetterdaten();

            var wintergarten = (Markisensteuerung)wohnung.GetZimmer("Wintergarten");
            Assert.IsFalse(wintergarten.markiseEingefahren);
        }
    }
}
