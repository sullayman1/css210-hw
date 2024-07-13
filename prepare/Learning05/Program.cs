class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        // Square sArea = new Square("red", 5);
        // // string color = sArea.GetColor();
        // // double area = sArea.GetArea();

        // Rectangle rArea = new Rectangle("blue", 4, 5);
        // // string color = rArea.GetColor();
        // // double area = rArea.GetArea();

        // Circle cArea = new Circle("green", 6);
        // string color = cArea.GetColor();
        // double area = cArea.GetArea();

        // Console.WriteLine($"The {color} shape has an area of {area}");

        List<Shape> shapes = new List<Shape>();
        Square square = new Square ("red", 3);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("blue", 4, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("green", 5);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
            
        }

    }
}