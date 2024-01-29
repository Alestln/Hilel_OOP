using Hilel_OOP.Entities;
using Hilel_OOP.Interfaces;

namespace Hilel_OOP;

class Program
{
    static void Main(string[] args)
    {
        List<IAnimal> animals = new List<IAnimal>()
        {
            new Fish(),
            new Horse("Caitlin", "John", 5),
            new Parrot("Justin", "Julia", 4),
            new Cat()
            {
                Name = "Mozart",
                OwnerName = "Alex",
                Age = 11
            }
        };

        foreach (var animal in animals)
        {
            animal.SayHello();
        }
    }
}