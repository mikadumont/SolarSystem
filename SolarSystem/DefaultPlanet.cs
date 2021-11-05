namespace SolarSystem;

public class DefaultPlanet : Planet
{
    public DefaultPlanet(double diameter, string? composition, double mass) : base(diameter, composition, mass)
    {
    }

    public DefaultPlanet() : this(default, default, default) { }
}

public interface GasGiant
{
}

public class Mercury : DefaultPlanet
{
}

public class Venus : DefaultPlanet
{
}

public class Mars : DefaultPlanet
{
}

public class Jupiter : DefaultPlanet, GasGiant
{
}

public class Saturn : DefaultPlanet, GasGiant
{
}

public class Uranus : DefaultPlanet, GasGiant
{
}

public class Neptune : DefaultPlanet, GasGiant
{
}
