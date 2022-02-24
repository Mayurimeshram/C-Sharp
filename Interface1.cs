using System;
public interface Drawable
{
    void Draw();
}
 public class Rectangle: Drawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing Reactangle.....");
    }
}
 public class Circle: Drawable

{
    public void Draw()
    {
        Console.WriteLine("Drawing circle....");
    }
}
 public class TestInterface
{
    public static void Main()
    {
        Drawable d;
        d = new Rectangle();
        d.Draw();
        d = new Circle();
        d.Draw();

    }
}
