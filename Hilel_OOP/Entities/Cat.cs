using Hilel_OOP.Interfaces;

namespace Hilel_OOP.Entities;

public class Cat : IAnimal
{
    public Cat()
    {
        Name = default;
        OwnerName = default;
        Age = default;
    }

    public Cat(string name, string ownerName, int age)
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
        Console.WriteLine("Meaw");
    }
}