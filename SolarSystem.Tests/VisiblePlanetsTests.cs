using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace SolarSystem.Tests
{
    [TestClass]
    public class VisiblePlanetsTests
    {
        [TestMethod]
        public void PlanetDataParseTest()
        {
            string fileName = "C:\\Code\\Demo\\2021 VSLaunch and NETConf\\BlazorServer SolarSystem2\\SolarSystem\\SolarSystem\\Data\\VisiblePlanetsData.json";
            using FileStream openStream = File.OpenRead(fileName);

            VisiblePlanets[] planetDates = JsonSerializer.Deserialize<VisiblePlanets[]>(openStream);
            foreach(VisiblePlanets planet in planetDates)
            {
                planet.ParseDateTime();
            }

            int x = 0;
        }
    }
}