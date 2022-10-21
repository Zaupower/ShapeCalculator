namespace AreaCalculator;


//NEED TO IMPLEMENT TRY CATCH EXCEPTIONS
public class Circle: Shape
{
    public double Radius
    {
        get;
        set;
    }
    public override double CalculateArea()
    {
        return Math.PI * (Math.Pow(Radius, 2));
    }

    public override double ClaculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}