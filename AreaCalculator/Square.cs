namespace AreaCalculator;
//NEED TO IMPLEMENT TRY CATCH EXCEPTIONS
public class Square: Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return this.Side * Side;
    }

    public override double CalculatePerimeter()
    {
        return this.Side * 4;
    }
}