using System;

namespace SolarSystem
{
    public class Moon
    {
        public bool waning;
        public bool waxing;
        public double daysTillFull;
        public static void LunarEclipse(){}

        public static void CompletedOrbit() { }
        public static void CompletedRotation() { }
        public static void PullTides() { }

        public static string FindDaysTillFullMoon()
        {
            DateTime today = DateTime.Now;

            // Full Moon Phase Sept 2021
            DateTime firstFullMoon = new DateTime(2021, 08, 22, 08, 22, 0);

            // Full moons are *about* every 29.5 days
            int days = today.Subtract(firstFullMoon).Days;

            var moonsAgo = days / 29.5;

            // Round up since we are looking for the next full moon
            var fullMoonsAgo = Math.Ceiling(moonsAgo);

            var nextFullMoon = firstFullMoon.AddDays(29.5 * fullMoonsAgo);
            var daysTill = nextFullMoon.Subtract(today).TotalDays;

            return Math.Floor(daysTill).ToString();
        }
    }

    public class Solar : Moon
    {

    }
}
