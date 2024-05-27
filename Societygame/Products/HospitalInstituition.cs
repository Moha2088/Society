using SocietyGame.Entities;
using SocietyGame.Interfaces;

namespace Societygame.Products;
public class HospitalInstituition : IInstituition
{
    private decimal Cost { get; set; }


    public void Establish()
    {
        Console.WriteLine("Enter the name of the hospital:");
        string? name = Console.ReadLine();

        Console.WriteLine("Enter the cost of the hospital:");
        decimal cost = decimal.Parse(Console.ReadLine());

        Hospital hospital = new HospitalBuilder()
            .setName(name)
            .setCost(cost)
            .Build();

        Console.WriteLine($"{hospital.Name} has been built.");

        Cost = hospital.Cost;
    }

    public void GetCost()
    {
        Console.WriteLine($"The hospital has cost the government {Cost} kr.");
    }
}
