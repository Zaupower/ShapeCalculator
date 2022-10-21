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
        double Area = 0;
        double semiperimeter = (SideA + SideB + SideC) / 2;
        
         Area = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
         return Area;
    }

    
    public override double ClaculatePerimeter()
    {
        return SideA + SideB + SideC;
    }
}