public class JoinedData
{

    public int ID { get; set; }

    public string Name { get; set; }
    public Dictionary<string, List<int>> Subjects { get; set; } = new Dictionary<string, List<int>>();

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"\n{ID}:\n{Name}");
        foreach (var subject in Subjects)
        {
            sb.Append($"\n{subject.Key}: ");
            foreach (var mark in subject.Value)
            {
                sb.Append($"{mark},");
            }
        }

        return sb.ToString();
    }

}