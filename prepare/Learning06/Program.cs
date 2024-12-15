using System;

class Program
{
    static void Main(string[] args)  // In this program I used Chat GPT to help me understand the material. I typed everything my self and verified the content with the assignment sample solution. Thanks!
    {
        // Test shapes
        Square square = new Square("Red", 4);
        Console.WriteLine($"Square Color: {square.GetColor()}, Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 5, 3);
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 2);
        Console.WriteLine($"Circle Color: {circle.GetColor()}, Area: {circle.GetArea()}");

        // Creating list for shapes
        List<Shape> shapes = new List<Shape> {square, rectangle, circle};

        // Display the shapes
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}