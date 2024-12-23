namespace binary_node2;

public class BinaryNode<T>
{
    private T Value { get; set; }
    BinaryNode<T> LeftChild;
    BinaryNode<T> RightChild;
    
    internal BinaryNode(T value)
    {
        Value = value;
        LeftChild = null;
        RightChild = null;

    }
    internal void AddLeft(BinaryNode<T> childLink)
    {
        LeftChild = childLink;
    }
    
    internal void AddRight(BinaryNode<T> childLink)
    {
        RightChild = childLink;
    }

    public override string ToString()
    {
        var output = ToString("");
        return output;
    }

    private string ToString(string spaces)
    {
        string result = string.Format("{0}{1}:\n", spaces,Value);
        
        if ((RightChild != null) || (LeftChild != null))
        {
            if (LeftChild == null)
            {
                result += string.Format("{0}{1}null\n", spaces,"  ");
            }
            else
            {
                result += LeftChild.ToString(spaces + "  ");
            }

            if (RightChild == null)
            {
                result += string.Format("{0}{1}null\n", spaces,"  ");
            }
            else
            {
                result += RightChild.ToString(spaces + "  ");
            }

        }
        return result;
    }
    
}