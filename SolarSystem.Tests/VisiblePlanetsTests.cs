using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.IO;
using System.ServiceModel.Syndication;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace SolarSystem.Tests
{
    [TestClass]
    public class VisiblePlanetsTests
    {
        [TestMethod]
        public void PlanetDataParseTest()
        {
            string filePath = Path.GetFullPath("Data\\VisiblePlanetsData.json");
            using FileStream openStream = File.OpenRead(filePath);
            DateTime today = DateTime.Today;

            VisiblePlanets[] planetDates = JsonSerializer.Deserialize<VisiblePlanets[]>(openStream);

            Console.WriteLine("Visible Planets:");

            foreach (VisiblePlanets planet in planetDates)
            {
                planet.ParseDateTime();
                if (today.CompareTo(planet.start) > 0 && today.CompareTo(planet.end) < 0)
                {
                    Console.WriteLine(planet.Planet);
                }
            }
        }

        [TestMethod]
        public void RssFeedTest()
        {
            string url = "https://www.nasa.gov/rss/dyn/solar_system.rss";

            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            Console.WriteLine("NASA RSS Feed");
            string subject = "";
            string summary;

            foreach (SyndicationItem item in feed.Items)
            {
                subject = item.Title.Text;
                summary = item.Summary.Text;

                Console.WriteLine(subject);
                Console.WriteLine(summary);
            }

            Assert.IsTrue(subject.Length > 1);
        }

        [TestMethod]
        public void PrintLongTruncation()
        {
            string url = "https://www.nasa.gov/rss/dyn/solar_system.rss";

            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            Console.WriteLine("NASA RSS Feed:");
            string subject = "";
            string summary;

            for (int i = 0; i < 100; i++)
            {
                foreach (SyndicationItem item in feed.Items)
                {
                    subject = item.Title.Text;
                    summary = item.Summary.Text;

                    Console.WriteLine(subject);
                    Console.WriteLine(summary);
                }
            }

            Assert.IsTrue(subject.Length > 1);
        }

        [TestMethod]
        public void PrintStdErr()
        {
            Console.Error.WriteLine("This method throws IO File Not Found Exception." +
                "\nStandard error writes also appear in Test Explorer output.");

            // File Not Found Exception
            string filePath = Path.GetFullPath("Non-existent-file.json");
            using FileStream openStream = File.OpenRead(filePath);

        }

    }
}