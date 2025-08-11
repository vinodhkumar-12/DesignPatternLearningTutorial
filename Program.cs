using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(1,1);
        rect.AreaofRectangle();

        Triangle t = new Triangle(2,3);
        t.AreaofTriangle();

        IRectangle adapter = new TriangleAdapter(t);

        Program program = new Program();
        program.GetArea(adapter);
    }

    public void GetArea(IRectangle t)
    {
        t.AreaofRectangle();
    }
}


public interface IRectangle
{
    public int AreaofRectangle();
}

public interface ITriangle
{
    public int AreaofTriangle();
}


public class Rectangle : IRectangle
{
    public int length { get; set; }
    public int breadth { get; set; }

    public Rectangle(int length, int breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }
    public int AreaofRectangle()
    {
        Console.WriteLine("Area of Rectangle is {0}", length * breadth);
        return length * breadth;
    }
}

public class Triangle : ITriangle
{
    public int breadth { get; set; }
    public int height { get; set; }

    public Triangle(int breadth, int height)
    {
        this.breadth =breadth;
        this.height = height;
    }
    public int AreaofTriangle()
    {
        Console.WriteLine("Area of Triangle is {0}", (int)(0.5 * breadth * height));
        return (int)(0.5 * breadth * height);
    }
}

public class TriangleAdapter : IRectangle
{

    Triangle _t;
    public TriangleAdapter(Triangle t)
    {
        _t = t;
    }

    public int AreaofRectangle()
    {
        return _t.AreaofTriangle();
    }
}
