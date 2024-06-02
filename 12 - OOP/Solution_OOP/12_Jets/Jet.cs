public class Jet : Plane
{
    public int NumberOfRockets { get; private set; }

    public Jet(string model, string type, double speed) : base(model, type, speed)
    {
        this.NumberOfRockets = new Random().Next(1, 11);
    }

    public override void Attack()
    {
        
        if (this.NumberOfRockets == 0)
        {
            Console.WriteLine("No more rockets!");
            return;
        }

        Console.WriteLine("Rocket lunched!");
        this.NumberOfRockets--;
    }
}
