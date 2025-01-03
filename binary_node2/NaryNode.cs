namespace binary_node2;

public class NaryNode<T>
{
    private T Value { get; set; }
    private List<NaryNode<T>> Children;
    
    internal NaryNode(T value)
    {
        Value = value;
        Children = new List<NaryNode<T>>();
    }

    internal void AddChild(NaryNode<T> child)
    {
        Children.Add(child);
    }

    public override string ToString()
    {
        return ToString("");
    }

    public string ToString(string space)
    {
        string result = string.Format("{0}{1}:\n", space, Value);
        foreach (var s in Children)
        {
            result += s.ToString(space + "  ");
        }
        
        return result;
    }
}