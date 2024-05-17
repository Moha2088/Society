using SocietyGame.Enums;
using Societygame.Factory;
using Societygame.Products;
using SocietyGame.Interfaces;

namespace Societygame;

class Program
{
    static void Main()
    {
        Console.WriteLine("Press Enter to create a government!");
        Console.ReadLine();
        bool running = true;
        var level = new SocietyLevel();
        var government = GovSingleton.GetInstance();
        var createdInst = new List<IInstituition>();
        
        while (running)
        { 
            void CheckLevel(int count)
            {
                switch (count)
                {
                    case 1:
                        level = SocietyLevel.Primitive;
                        Console.WriteLine($"Society level is now: {level.ToString()}!");
                        break;

                    case 2:
                        level = SocietyLevel.Medium;
                        Console.WriteLine($"Society level is now: {level.ToString()}!");
                        break;

                    case 3:
                        level = SocietyLevel.Advanced;
                        Console.WriteLine($"Society level is now: {level.ToString()}! You have now reached peak society!");
                        break;
                }    
            }

        instPrompt:
            try
            {
                Console.WriteLine("Press 1 to build a hospital, 2 for a military, 3 for a university, or 4 to build a new government");
                int count = int.Parse(Console.ReadLine());

                switch (count)
                {
                    case 1:
                        IInstituition hospitalInst = GovFactory.Build(count);
                        createdInst.Add(hospitalInst);
                        hospitalInst.Establish();
                        CheckLevel(createdInst.Count);
                        hospitalInst.GetCost();
                        break;


                    case 2:
                        IInstituition militaryInst = GovFactory.Build(count);
                        createdInst.Add(militaryInst);
                        militaryInst.Establish();
                        CheckLevel(createdInst.Count);
                        militaryInst.GetCost();
                        break;


                    case 3:
                        IInstituition universityInst = GovFactory.Build(count);
                        createdInst.Add(universityInst);
                        universityInst.Establish();
                        CheckLevel(createdInst.Count);
                        universityInst.GetCost();
                        break;

                    case 4:
                        var newGovernment = GovSingleton.GetInstance();
                        break;

                    default:
                        throw new ArgumentException("Only integers from 1-4 are valid");
                }
            }

            catch (FormatException e)
            {
                Console.WriteLine($"Wrong data type. Try again! {e.ToString()}");
                goto instPrompt;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}