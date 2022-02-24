using System;
public class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("Eating.....");

    }
}
  public class Dog: Animal
{
    public override void eat()
    {
        Console.WriteLine("Eating Bread.....");
    }
}
   public class TestOverriding
{
    public static void Main()
    {
        Animal d = new Dog();
        d.eat();

    }
}