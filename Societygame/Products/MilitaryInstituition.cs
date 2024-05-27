using SocietyGame.Entities;
using SocietyGame.Interfaces;

namespace Societygame.Products;
public class MilitaryInstituition : IInstituition
{
    private decimal Cost { get; set; }


    public void Establish()
    {
        Console.WriteLine("Enter the name of the military:");
        string? name = Console.ReadLine();

        Console.WriteLine("Enter the cost of the military:");
        decimal cost = decimal.Parse(Console.ReadLine());

        Military military = new MilitaryBuilder()
            .setName(name)
            .setCost(cost)
            .Build();

        Console.WriteLine($"{military.Name} has been built.");

        Cost = military.Cost;
    }

    public void GetCost()
    {
        Console.WriteLine($"The military has cost the government {Cost} kr.");
    }
}