namespace WpfApp1;

public class Node
{
    public string Value { get; set; } = null!;
    public List<Node>? Links { get; set; }
}