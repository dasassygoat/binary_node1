namespace binary_node1;

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
        string result = string.Format("{0}:", Value);
        if (LeftChild == null)
        {
            result += " null ";
        }
        else
        {
            result += string.Format($" {LeftChild.Value} ");
        }

        if (RightChild == null)
        {
            result += " null ";
        }
        else
        {
            result += string.Format($" {RightChild.Value} ");
        }

        return result;
    }
}