namespace Figures;

public abstract class Figure(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public abstract void ShowArea();
}

public class Circle(int r) : Figure(r, r)
{
    public override void ShowArea()
    {
        Console.WriteLine($"Circle area: {Math.PI * X * X}");
    }
}

public class Rectangle(int x, int y) : Figure(x, y)
{
    public override void ShowArea()
    {
        Console.WriteLine($"Rectangle area: {X * Y}");
    }
}

public class Triangle(int x, int y, int height) : Figure(x, y)
{
    public int Height { get; set; } = height;
    
    public override void ShowArea()
    {
        Console.WriteLine($"Triangle area: {(Height * Y) / 2}");
    }
}
