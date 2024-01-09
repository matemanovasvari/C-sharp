public class Car
{
    public string Plate {  get; set; }
    public double GasAmount {  get; set; }

    public Car()
    {
            
    }

    public Car(string plate, double gasAmount)
    {
        Plate = plate;
        GasAmount = gasAmount;
    }
}