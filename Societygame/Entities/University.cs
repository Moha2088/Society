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

public class UniversityBuilder
{
    private string name = null!;
    private decimal cost;

    public UniversityBuilder setName(string name) 
    {
        this.name = name; 
        return this; 
    }

    public UniversityBuilder setCost(decimal cost) 
    {
        this.cost = cost;
        return this;
    }

    public University Build() 
    {
        return new University(name, cost);
    }
}