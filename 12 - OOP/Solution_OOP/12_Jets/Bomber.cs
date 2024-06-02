using System;

public class Bomber : Plane
{
    public int NumberOfBombs = new Random().Next(1, 11);

    public Bomber(string model, string type, double speed) : base(model, type, speed)
    {
        this.NumberOfBombs = new Random().Next(1, 11);
    }

    public override void Attack()
    {
        if (this.NumberOfBombs == 0)
        {
            Console.WriteLine("No more bombs!");
            return;
        }

        int dropedBomps = new Random().Next(1, this.NumberOfBombs + 1);
        Console.WriteLine($"{dropedBomps} bombs are dropped!");
        this.NumberOfBombs -= dropedBomps;
    }
}
