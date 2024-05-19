namespace PCBuilder.Model;

public abstract class PcItem
{
    public string? Name { get; set; }
    public int Price { get; set; }
}

public class Motherboard : PcItem
{
    public string? Manufacturer { get; set; }
    public string? Type { get; set; }
}