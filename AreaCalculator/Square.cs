namespace AreaCalculator;
//NEED TO IMPLEMENT TRY CATCH EXCEPTIONS
public class Square: Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return Math.Round(this.Side * Side, 2);
    }

    public override double CalculatePerimeter()
    {
        return Math.Round(this.Side * 4, 2);
    }
}