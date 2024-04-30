namespace SocietyGame.Entities;

public class Military
{
    public string Name { get; set; }

    public decimal Cost { get; set; }



    public Military(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}