namespace InterfaceSandbox
{
    public class ModLibCalc : ICalculations
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public float CalculateArea()
        {
            return Length * Width;
        }
    }
}
