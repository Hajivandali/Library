using test;
using static test.Obj;

public class ModelComparer : IEqualityComparer<model>
{
    public bool Equals(model x, model y)
    {
        return StringComparer.OrdinalIgnoreCase.Equals(x.Name, y.Name);
    }

    public int GetHashCode(model obj)
    {
        return StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name);
    }
}
