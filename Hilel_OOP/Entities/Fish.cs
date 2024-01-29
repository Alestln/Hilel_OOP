using Hilel_OOP.Interfaces;

namespace Hilel_OOP.Entities;

public class Fish : IAnimal
{
    public Fish()
    {
        Name = default;
        OwnerName = default;
        Age = default;
    }

    public Fish(string name, string ownerName, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public string Name { get; set; }
    public string OwnerName { get; set; }
    public int Age { get; set; }
}