using System;

namespace SolarSystem
{
    public class Moon
    {
        public bool waning;
        public bool waxing;
        public double daysTillFull;
        public static void LunarEclipse()
        {

        }

        public static void CompletedOrbit() { }
        public static void CompletedRotation() { }
        public static void PullTides() { }

        public static string FindDaysTillFullMoon()
        {
            DateTime today = DateTime.Now;

            // Full Moon Phase Sept 2021
            DateTime firstFullMoon = new DateTime(2021, 09, 20, 19, 55, 0);

            // Full moons are *about* every 29.5 days
            TimeSpan days = firstFullMoon.Subtract(today);
            var findFullMoon = new DateTime();

            while (today < findFullMoon)
            {
                findFullMoon.AddDays(29.5);
            }

            findFullMoon.AddDays(29.5);

            var daysTill = today.Subtract(findFullMoon);

            var moonsAgo = days / 29.5;

            return daysTill.TotalDays.ToString();

        }

    }

    public class Solar : Moon
    {

    }
}
