using SocietyGame.Entities;
using SocietyGame.Interfaces;

namespace Societygame.Products;
public class UniversityInstituition : IInstituition
{
    private decimal Cost { get; set; }


    public void Establish()
    {
        Console.WriteLine("Enter the name of the university:");
        string? name = Console.ReadLine();

        Console.WriteLine("Enter the cost of the university:");
        decimal cost = decimal.Parse(Console.ReadLine());

        University university = new UniversityBuilder()
            .setName(name)
            .setCost(cost)
            .Build();

        Console.WriteLine($"{university.Name} has been built.");

        Cost = university.Cost;
    }

    public void GetCost()
    {
        Console.WriteLine($"The university has cost the government {Cost} kr.");
    }
}
