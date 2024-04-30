using SocietyGame.Entities;
using SocietyGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societygame.Products;
public class MilitaryInstituition : IInstituition
{
    private decimal Cost { get; set; }


    public void Establish()
    {
        Console.WriteLine("Enter the name of the military:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the cost of the military:");
        decimal cost = decimal.Parse(Console.ReadLine());

        var military = new University(name, cost);

        Console.WriteLine($"{military.Name} has been built at the cost of: {military.Cost} kr.");

        Cost = military.Cost;
    }

    public string GetCost()
    {
        return Cost > 0 ? $"The military has cost the government {Cost} kr." 
            : "A military has not been built yet!";
    }
}