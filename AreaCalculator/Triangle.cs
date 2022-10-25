namespace AreaCalculator;
//NEED TO IMPLEMENT TRY CATCH EXCEPTIONS
public class Triangle:Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }
    
    //heron’s formula
    public override double CalculateArea()
    {
        double semiperimeter = (SideA + SideB + SideC) / 2;
        var area = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
        return Math.Round(area, 2);
    }

    
    public override double CalculatePerimeter()
    {
        return Math.Round(SideA + SideB + SideC, 2);
    }
}