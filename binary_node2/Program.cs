using Microsoft.VisualBasic.CompilerServices;

namespace binary_node2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BinaryNode2 Project");
        BinaryNode<string> root = new BinaryNode<string>("Root");
        BinaryNode<string> a = new BinaryNode<string>("A");
        BinaryNode<string> b = new BinaryNode<string>("B");
        BinaryNode<string> c = new BinaryNode<string>("C");
        BinaryNode<string> d = new BinaryNode<string>("D");
        BinaryNode<string> e = new BinaryNode<string>("E");
        BinaryNode<string> f = new BinaryNode<string>("F");
        e.AddLeft(f);
        b.AddRight(e);
        a.AddLeft(c);
        a.AddRight(d);
        root.AddLeft(a);
        root.AddRight(b);

        Console.WriteLine(root.ToString());
        Console.WriteLine(a.ToString());
        // Console.WriteLine(b.ToString());
        // Console.WriteLine(c.ToString());
        // Console.WriteLine(d.ToString());
        // Console.WriteLine(e.ToString());
        // Console.WriteLine(f.ToString());

        // NaryNode<string> rootNary = new NaryNode<string>("Root");
        // NaryNode<string> aNary = new NaryNode<string>("A");
        // NaryNode<string> bNary = new NaryNode<string>("B");
        // NaryNode<string> cNary = new NaryNode<string>("C");
        // NaryNode<string> dNary = new NaryNode<string>("D");
        // NaryNode<string> eNary = new NaryNode<string>("E");
        // NaryNode<string> fNary = new NaryNode<string>("F");
        // NaryNode<string> gNary = new NaryNode<string>("G");
        // NaryNode<string> hNary = new NaryNode<string>("H");
        // NaryNode<string> iNary = new NaryNode<string>("I");
        //
        // fNary.AddChild(hNary);
        // fNary.AddChild(iNary);
        // cNary.AddChild(fNary);
        // dNary.AddChild(gNary);
        // aNary.AddChild(eNary);
        // aNary.AddChild(dNary);
        // rootNary.AddChild(aNary);
        // rootNary.AddChild(bNary);
        // rootNary.AddChild(cNary);
        // Console.WriteLine("\n-----------\n");
        // Console.WriteLine(rootNary.ToString());
        // Console.WriteLine(aNary.ToString());
        // Console.WriteLine(bNary.ToString());
        // Console.WriteLine(cNary.ToString());
        // Console.WriteLine(dNary.ToString());
        // Console.WriteLine(eNary.ToString());
        // Console.WriteLine(fNary.ToString());
        // Console.WriteLine(gNary.ToString());
        // Console.WriteLine(hNary.ToString());
        // Console.WriteLine(iNary.ToString());

    }
}