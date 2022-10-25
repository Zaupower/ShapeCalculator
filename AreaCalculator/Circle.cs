namespace AreaCalculator;


//NEED TO IMPLEMENT TRY CATCH EXCEPTIONS
public class Circle: Shape
{
    public double Radius { get; set; }
    public override double CalculateArea()
    {
        return Math.Round( Math.PI * Math.Pow(Radius, 2), 2);
    }

    public override double CalculatePerimeter()
    {
        return Math.Round( 2 * Math.PI * Radius, 2);
    }
}