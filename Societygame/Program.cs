using Societygame.Factory;
using SocietyGame.Interfaces;

namespace Societygame;

class Program
{
    static void Main()
    {
        var government = GovSingleton.GetInstance();
        var factory = new GovFactory();

        Console.WriteLine("Press 1 to build an instituition, and 2 to manage an instituition");
        int count = int.Parse(Console.ReadLine());

        switch(count)
        {
            case 1:
                break;
        }
    }
}