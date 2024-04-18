﻿using System.Reflection;

namespace _02_Inheritance;

public class Processor : Hardware
{
    public int NumberOfCores { get; set; }

    public double Frequency { get; set; }

    public Processor() : base()
    {
        
    }

    public Processor(string manufacturer, string model, string type, int numberOfCores, double frequency) : base(manufacturer, model, type)
    {
        NumberOfCores = numberOfCores;
        Frequency = frequency;
    }

    public Processor(int numberOfCores, double frequency)
    {
        NumberOfCores = numberOfCores;
        Frequency = frequency;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\t\tnumber of cores: {NumberOfCores}\tfrequency: {Frequency}GHz";
    }
}
