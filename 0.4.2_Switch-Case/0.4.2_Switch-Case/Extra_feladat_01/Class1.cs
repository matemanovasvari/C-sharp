public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double BenchWeight { get; set; }
    public override string ToString()
    {
        return $"{this.Name}, {this.Age}, {this.Weight}, {this.BenchWeight}";
    }
}
