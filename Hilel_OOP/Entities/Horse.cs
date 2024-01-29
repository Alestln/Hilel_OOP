using Hilel_OOP.Interfaces;

namespace Hilel_OOP.Entities;

public class Horse : IAnimal
{
    public Horse()
    {
        Name = default;
        OwnerName = default;
        Age = default;
    }

    public Horse(string name, string ownerName, int age)
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
        Console.WriteLine("Neigh");
    }
}