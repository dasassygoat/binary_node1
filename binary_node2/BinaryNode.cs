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
        string result = string.Format("{0}:\n", Value);
        if (LeftChild == null)
        {
            result += " null ";
        }
        else
        {
            result += string.Format($"{spaces}{LeftChild.Value}\n");
        }

        if (RightChild == null)
        {
            result += " null ";
        }
        else
        {
            result += string.Format($"{spaces}{RightChild.Value}\n");
        }

        return result;
    }
}