namespace M320_SmartHome.Test
{
    [TestClass]
    public class HeizungsventilTest

    {
        [TestMethod]
        public void HeizungsventilOffenZimmer19_Aussen18()
        {
            // TODO:
            // 1) Klasse WettersensorMock erstellen, welche die fixe Aussentemperatur 18°C als Wetterdaten "generiert"
            //
            // 2) Wohnung instanzieren und WettersensorMock als Wettersensor im Konstruktor uebergeben.
            //
            // 3) Temperaturvorgabe fuer Wohnzimmer: 19°C
            //
            // 4) Wohnung.GenerateWetterdaten() aufrufen
            //
            // 5) Wohnzimmer ueberpruefen, ob Heizungsventil offen 

          

            var wettersensorMock = new WettersensorMock(18, false, 35);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

            wohnung.GenerateWetterdaten();

            var wohnzimmer = (Heizungsventil)wohnung.GetZimmer("Wohnzimmer");
            Assert.IsTrue(wohnzimmer.heizungsventilOffen);


        }
        [TestMethod]
        public void HeizungsventilZuZimmer21_Aussen20()
        {
            


            var wettersensorMock = new WettersensorMock(21, false, 35);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 20);

            wohnung.GenerateWetterdaten();

            var wohnzimmer = (Heizungsventil)wohnung.GetZimmer("Wohnzimmer");
            Assert.IsFalse(wohnzimmer.heizungsventilOffen);
        }
        [TestMethod]
        public void HeizungsventilZuZimmer20_Aussen19()
        {

            var wettersensorMock = new WettersensorMock(20, false, 35);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 19);

            wohnung.GenerateWetterdaten();

            var wohnzimmer = (Heizungsventil)wohnung.GetZimmer("Wohnzimmer");
            Assert.IsFalse(wohnzimmer.heizungsventilOffen);
        }
        [TestMethod]
        public void HeizungsventilOffenZimmer_26_Aussen_25()
        {
           
            var wettersensorMock = new WettersensorMock(-26, false, 35);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", -25);

            wohnung.GenerateWetterdaten();

            var wohnzimmer = (Heizungsventil)wohnung.GetZimmer("Wohnzimmer");
            Assert.IsTrue(wohnzimmer.heizungsventilOffen);
        }
        [TestMethod]
        public void HeizungsventilZuZimmer36_Aussen_35()
        {
            

            var wettersensorMock = new WettersensorMock(36, false, 35);
            var wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 35);

            wohnung.GenerateWetterdaten();

            var wohnzimmer = (Heizungsventil)wohnung.GetZimmer("Wohnzimmer");
            Assert.IsFalse(wohnzimmer.heizungsventilOffen);
        }
    }

}