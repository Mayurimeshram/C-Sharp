using System;
public class shape
{
    public virtual void Draw()
    {
        Console.WriteLine("drawing..");
    }
}
 public class rectangle:shape
{
    public override void Draw()
    {
        Console.WriteLine("drawing rectangle.....");
    }

}
  public class circle: shape
{
    public override void Draw()
    {
        Console.WriteLine("drawing circle....");
    }
}
   public class Testpolymorphism
{
    public static void Main()
    {
        shape s;
        s = new shape();
        s.Draw();
        s = new rectangle();
        s.Draw();
        s = new circle();
        s.Draw();




    }
}