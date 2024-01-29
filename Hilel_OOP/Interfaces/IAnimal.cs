namespace Hilel_OOP.Interfaces;

public interface IAnimal
{
    string Name { get; set; }
    string OwnerName { get; set; }
    int Age { get; set; }

    void SayHello()
    {
        Console.WriteLine("I am default implementation");
    }
}