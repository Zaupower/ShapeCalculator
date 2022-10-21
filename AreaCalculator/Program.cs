// See https://aka.ms/new-console-template for more information

/*
Task 1

Create classes Square, Triangle, Circle, Shape.  
Define methods for calculating area and perimeter for them.  
Determine which of these classes can be abstract.


Shape class can be abstract because there are no need to creat objects type Shape
*/

using AreaCalculator;

class Program
{
    static void Main(string[] args)
    {
        Triangle t = new Triangle();
        t.SideA = 2;
        t.SideB = 3;
        t.SideC = 4;
        
        Console.WriteLine(t.CalculateArea());
        Console.WriteLine(t.ClaculatePerimeter());
        

        Square s = new Square();
        s.Side = 4;
        Console.WriteLine(s.CalculateArea());
        Console.WriteLine(s.ClaculatePerimeter());

        Circle c = new Circle();
        c.Radius = 10;
        Console.WriteLine(c.CalculateArea());
        Console.WriteLine( c.ClaculatePerimeter());
       
    }
}