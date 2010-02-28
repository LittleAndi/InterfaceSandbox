namespace InterfaceSandbox
{
    public interface ICalculations
    {
        int Length { get; set; }
        int Width { get; set; }

        float CalculateArea();
    }
}
