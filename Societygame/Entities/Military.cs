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

public class MilitaryBuilder
{
    private string name = null!;
    private decimal cost;

    public MilitaryBuilder setName(string name)
    {
        this.name = name;
        return this;
    }

    public MilitaryBuilder setCost(decimal cost) 
    {
        this.cost = cost;
        return this; 
    }

    public Military Build()
    {
        return new Military(name, cost);
    }
}