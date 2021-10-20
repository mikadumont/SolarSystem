using System;
using System.Text.Json;

public class Planet
{
    public static void CompletedRotation() { }
}

public interface GasGiant
{
}

public class Mercury : Planet
{
}

public class Venus : Planet
{
}

public class Mars : Planet
{
}

public class Jupiter : Planet, GasGiant
{
}

public class Saturn : Planet, GasGiant
{
}

public class Uranus : Planet, GasGiant
{
}

public class Neptune : Planet, GasGiant
{
}