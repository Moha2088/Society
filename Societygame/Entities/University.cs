namespace SocietyGame.Entities;

public class University
{
    public string Name { get; set; }

    public decimal Cost { get; set; }



    public University(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}