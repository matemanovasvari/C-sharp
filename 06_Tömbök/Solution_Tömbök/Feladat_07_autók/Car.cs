public class Car
{
    public string Plate {  get; set; }
    public int Speed {  get; set; }
    public int Fine { get; set; }

    public Car()
    {
            
    }

    public Car(string plate, int speed, int fine)
    {
        Plate = plate;
        Speed = speed;
        Fine = fine;
    }
}