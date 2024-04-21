namespace XanPadPlusPlus.Models;

public struct CaretPosition
{
    public int Line { get; set; }
    public int Col { get; set; }

    public CaretPosition(int line, int col)
    {
        Line = line;
        Col = col;
    }
}