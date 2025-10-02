namespace Howest.Functions;

public class CalculatorRequest
{
    public int A { get; set; }
    public int B { get; set; }
    public string Operation { get; set; } = string.Empty;
    public int Result { get; set; }
}