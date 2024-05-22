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

public class HospitalBuilder
{
    private string name = null!;
    private decimal cost;

    public HospitalBuilder setName(string name)
    {
        this.name = name;
        return this;
    }

    public HospitalBuilder setCost(decimal cost)
    {
        this.cost = cost;
        return this;
    }

    public Hospital Build()
    {
        return new Hospital(name, cost);
    }
}