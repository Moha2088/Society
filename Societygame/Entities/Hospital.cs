namespace SocietyGame.Entities;

public class Hospital
{
    public string Name { get; set; }

    public decimal Cost { get; set; }



    public Hospital(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}