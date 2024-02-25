using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_SmartHome.Test
{
    public class JalousiensteuerungTest
    {
        [TestMethod]
        public void JalousienOffenZimmer20_Aussen19_Person_Nein()
        {
            var wettersensorMock = new WettersensorMock(20, false, 25);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);
            wohnung.SetPersonenImZimmer("Wohnzimmer", false);


            wohnung.GenerateWetterdaten();

            var wohnzimmer = (Jalousiensteuerung)wohnung.GetZimmer("Wohnzimmer");
            Assert.IsTrue(wohnzimmer.jalousieOffen);
        }
        [TestMethod]
        public void JalousienOffenZimmer20_Aussen19_Person_Ja()
        {
            var wettersensorMock = new WettersensorMock(20, false, 25);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);


            wohnung.GenerateWetterdaten();

            var wohnzimmer = (Jalousiensteuerung)wohnung.GetZimmer("Wohnzimmer");
            Assert.IsFalse(wohnzimmer.jalousieOffen);
        }
        [TestMethod]
        public void JalousienOffenZimmer19_Aussen20_Person_Nein()
        {
            var wettersensorMock = new WettersensorMock(19, false, 25);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 20);
            wohnung.SetPersonenImZimmer("Wohnzimmer", false);


            wohnung.GenerateWetterdaten();

            var wohnzimmer = (Jalousiensteuerung)wohnung.GetZimmer("Wohnzimmer");
            Assert.IsFalse(wohnzimmer.jalousieOffen);
        }
        [TestMethod]
        public void JalousienOffenZimmer15_Aussen16_Person_Nein()
        {
            var wettersensorMock = new WettersensorMock(15, false, 25);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 16);
            wohnung.SetPersonenImZimmer("Wohnzimmer", false);


            wohnung.GenerateWetterdaten();

            var wohnzimmer = (Jalousiensteuerung)wohnung.GetZimmer("Wohnzimmer");
            Assert.IsTrue(wohnzimmer.jalousieOffen);
        }
        [TestMethod]
        public void JalousienOffenZimmer15_Aussen16_Person_Ja()
        {
            var wettersensorMock = new WettersensorMock(20, false, 25);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);


            wohnung.GenerateWetterdaten();

            var wohnzimmer = (Jalousiensteuerung)wohnung.GetZimmer("Wohnzimmer");
            Assert.IsFalse(wohnzimmer.jalousieOffen);
        }
    }
}
