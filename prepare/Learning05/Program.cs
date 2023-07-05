using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Gold", 4);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Black", 5, 2.5);
        shapes.Add(s2);

        Circle s3 = new Circle("White", 9);
        shapes.Add(s3);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}