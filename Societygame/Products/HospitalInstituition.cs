using SocietyGame.Entities;
using SocietyGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Societygame.Products;
public class HospitalInstituition : IInstituition
{
    public decimal Cost { get; set; }

 

    public void Establish()
    {
        Console.WriteLine("Enter the name of the hospital:");
        string? name = Console.ReadLine();

        Console.WriteLine("Enter the cost of the hospital:");
        decimal cost = decimal.Parse(Console.ReadLine());

        var hospital = new Hospital(name, cost);

        Console.WriteLine($"{hospital.Name} has been built at the cost of: {hospital.Cost} kr.");
    }

    public string GetCost()
    {
        return Cost > 0 ? $"The hospital has cost the government {Cost} kr."
            : "A hospital has not been built yet!";
    }
}
