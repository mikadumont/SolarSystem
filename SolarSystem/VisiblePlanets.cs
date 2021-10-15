using Microsoft.AspNetCore.Http;

namespace SolarSystem
{

    public class VisiblePlanets
    {
        public string Planet { get; set; }
        public string Time { get; set; }
        public string VisibleDateStart { get; set; }
        public string VisibleDateEnd { get; set; }

        public DateTime start { get; set; }
        public DateTime end { get; set; }

        public void ParseDateTime()
        {
            if (VisibleDateStart != null && VisibleDateEnd != null)
            {
                try
                {
                    start = DateTime.Parse(VisibleDateStart);
                    end = DateTime.Parse(VisibleDateEnd);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}'.", VisibleDateStart + "or" + VisibleDateEnd);
                }
            }
        }
    }

}
