using Hilel_OOP.Interfaces;

namespace Hilel_OOP.Entities;

public class Parrot : IAnimal
{
    public Parrot()
    {
        Name = default;
        OwnerName = default;
        Age = default;
    }

    public Parrot(string name, string ownerName, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public string Name { get; set; }
    public string OwnerName { get; set; }
    public int Age { get; set; }

    public void SayHello()
    {
        Console.WriteLine("Chirp");
    }
}