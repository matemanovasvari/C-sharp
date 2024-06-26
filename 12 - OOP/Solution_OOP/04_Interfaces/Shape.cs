﻿public abstract class Shape : IShape
{
    public abstract float Area();

    public abstract float Perimeter();

    public override string ToString()
    {
        return $"Area: {Area()}\nPerimeter: {Perimeter()}";
    }
}
