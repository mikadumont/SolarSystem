using Microsoft.AspNetCore.Http;

namespace SolarSystem
{

    public class VisiblePlanets
    {
        public string? Planet { get; set; }
        public string? Time { get; set; }
        public string? VisibleDateStart { get; set; }
        public string? VisibleDateEnd { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public void ParseDateTime()
        {
            if (VisibleDateStart != null && VisibleDateEnd != null)
            {
                try
                {
                    Start = DateTime.Parse(VisibleDateStart);
                    End = DateTime.Parse(VisibleDateEnd);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}'.", VisibleDateStart + "or" + VisibleDateEnd);
                    //throw new FormatException();
                }
            }
        }
    }

}
