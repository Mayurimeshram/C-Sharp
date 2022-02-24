using System;
 public class Animal
{
    public string color = "White";

}
 public  class Dog: Animal
{
    public string color = "Black";
}
    public class Testsealed
{
    public static void Main()
    {
        Animal d = new Dog();
        Console.WriteLine(d.color);
    }
}