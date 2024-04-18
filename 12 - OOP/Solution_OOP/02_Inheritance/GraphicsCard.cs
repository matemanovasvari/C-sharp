﻿
using _02_Inheritance;

public class GraphicsCard : Hardware
{
    

    public int Memory { get; set; }

    public string MemoryType { get; set; }

    public GraphicsCard() : base()
    {
        
    }

    public GraphicsCard(string manufacturer, string model, string type, int memory, string memoryType) : base(manufacturer, model, type)
    {
        Memory = memory;
        MemoryType = memoryType;
    }
}