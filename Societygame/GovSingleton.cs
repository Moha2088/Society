using Societygame.Factory;

public sealed class GovSingleton
{
    private static GovSingleton? _govInstance;



    private GovSingleton() { }

    public static GovSingleton GetInstance()
    {
        if (_govInstance == null)
        {
            _govInstance = new GovSingleton();
            Console.WriteLine("A new government has been established!");
        }

        else
        {
            Console.WriteLine("Two governments can't coexist! Please use the existing government");
        }

        return _govInstance;
    }
}