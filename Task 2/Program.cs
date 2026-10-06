namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        double radius = 5.0;
        
        /*Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Constant PI value: {Circle.PI}");*/
        
        Console.WriteLine($"Area: {Circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter: {Circle.CalculatePerimeter(radius)}");
    }
}