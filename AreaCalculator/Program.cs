// See https://aka.ms/new-console-template for more information

/*
Task 1

Create classes Square, Triangle, Circle, Shape.  
Define methods for calculating area and perimeter for them.  
Determine which of these classes can be abstract.


Shape class can be abstract because there are no need to creat objects type Shape
*/

namespace AreaCalculator;

class Program
{
    static void Main(string[] args)
    {
        Triangle t = new Triangle();
        t.SideA = 2;
        t.SideB = 3;
        t.SideC = 4;
        Console.WriteLine("Triangle Area: " + t.CalculateArea());
        Console.WriteLine("Triangle Perimeter: " + t.CalculatePerimeter());
        
        Console.WriteLine("");

        Square s = new Square();
        s.Side = 4;
        Console.WriteLine("Square Area: "+s.CalculateArea());
        Console.WriteLine("Square Perimeter: "+s.CalculatePerimeter());

        Console.WriteLine("");
        
        Circle c = new Circle();
        c.Radius = 10;
        Console.WriteLine("Circle Area: " + c.CalculateArea());
        Console.WriteLine("Circle Perimeter: " + c.CalculatePerimeter());
    }
}