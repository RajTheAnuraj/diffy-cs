namespace Diffy.Domain.Analysis;

public class FieldDifference
{
    public string Field { get; set; }
    public string Difference { get; set; }

    public FieldDifference(string field, string difference)
    {
        Field = field;
        Difference = difference;
    }
}
