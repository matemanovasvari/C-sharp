using System.ComponentModel;

public class Report
{
    public List<Error> Errors { get; set; } = new List<Error>();

    public int SuccessCount { get; set; }

    public DateTime Date = DateTime.Now;

    public Report()
    {

    }

    public Report(List<Error> errors, int success, DateTime date)
    {
        Errors = errors;
        SuccessCount = success;
        Date = date;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (Error error in Errors)
        {
            stringBuilder.Append(error.ToString());
        }
        stringBuilder.AppendLine($"Success count: {SuccessCount}");
        stringBuilder.AppendLine($"Date: {Date.ToString()}");

        return stringBuilder.ToString();
    }
}