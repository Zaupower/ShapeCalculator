namespace AreaCalculator;
//NEED TO IMPLEMENT TRY CATCH EXCEPTIONS
public class Square: Shape
{
    public double Side
    {
        get => Side;
        set => Side = value;
    }

    public override double CalculateArea()
    {
        return this.Side * 4;
    }

    public override double ClaculatePerimeter()
    {
        return this.Side * 4;
    }
}