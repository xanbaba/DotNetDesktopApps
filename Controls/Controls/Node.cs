using System.Collections.Generic;

namespace Controls;

public class Node
{
    public string Value { get; set; } = null!;
    public List<Node>? Links { get; set; }
}