namespace _02_Inheritance;

public class ARMProcessor : Processor
{
    public int NumberOfPowerCores { get; set; }

    public int NumberOfEfficient {  get; set; }

    public ARMProcessor() : base()
    {
    }

    public ARMProcessor(int numberOfPowerCores, int numberOfEfficient) : base()
    {
        NumberOfPowerCores = numberOfPowerCores;
        NumberOfEfficient = numberOfEfficient;
    }

    public ARMProcessor(int numberOfPowerCores, int numberOfEfficient, int numberOfCores, double frequency) : base(numberOfCores, numberOfEfficient)
    {
        NumberOfPowerCores = numberOfPowerCores;
        NumberOfEfficient = numberOfEfficient;
    }
}