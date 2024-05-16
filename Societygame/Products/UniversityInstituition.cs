using SocietyGame.Entities;
using SocietyGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societygame.Products;
public class UniversityInstituition : IInstituition
{
    public decimal Cost { get; set; }



    public void Establish()
    {
        Console.WriteLine("Enter the name of the university:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the cost of the university:");
        decimal cost = decimal.Parse(Console.ReadLine());

        var university = new University(name, cost);

        Console.WriteLine($"{university.Name} has been built at the cost of: {university.Cost} kr.");
    }

    public string GetCost()
    {
        return Cost > 0 ? $"The university has cost the government {Cost} kr."
            : "A university has not been built yet!";
    }
}
