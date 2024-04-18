public abstract class Vehicle
{
    //az öröklött osztályban feluldefiniálhatom (override),
    //de nem kötelező
    public virtual void Horn()
    {
        Console.Beep(1000, 1000);
    }

    public abstract void Error();//kötelező felüldefiniálni
}