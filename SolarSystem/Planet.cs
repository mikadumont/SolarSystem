using System;
using System.Text.Json;

public class Planet
{
    public static void CompletedRotation() { }

    public double Diameter { get; set; }
    public string? Composition { get; set; }    
    public double Mass { get; set; }

    public Planet(double diameter, string? composition, double mass)
    {
        Diameter = diameter;
        Composition = composition;
        Mass = mass;
    }
}
