public abstract class Plane : IPlane
{

    public string Model { get; private set; }

    public string Type { get; private set; }

    public double Speed { get; private set; }

    protected Plane(string model, string type, double speed)
    {
        this.Model = model;
        this.Type = type;
        this.Speed = speed;
    }

    public abstract void Attack();

    public void Attacks()
    {
        throw new NotImplementedException();
    }
}
