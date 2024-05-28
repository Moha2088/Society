using SocietyGame.Enums;
using Societygame.Factory;
using Societygame.Products;
using SocietyGame.Interfaces;

namespace Societygame;

public class Application
{
    public void Run()
    {
        Console.WriteLine("Press Enter to create a government!");
        Console.ReadLine();
        bool running = true;
        var level = new SocietyLevel();
        var government = GovSingleton.GetInstance();
        var createdInstList = GovFactory.instituitionsCreated;

        while (running)
        {
            GovFactory.MaxCountReached += MaxCountReachedAlert;
            GovFactory.DuplicateDetected += DuplicateAlert;

            void MaxCountReachedAlert()
            {
                Console.WriteLine("You have reached the maximum amount of instituitions!");
                Environment.Exit(0);
            }

            void DuplicateAlert(IInstituition inst)
            {
                Console.WriteLine($"An instituition of type: {inst} already exists!");
            }

            void CheckLevel(int count)
            {
                switch (count)
                {
                    case 1:
                        level = SocietyLevel.Primitive;
                        Console.WriteLine($"Society level is now: {level}!");
                        break;

                    case 2:
                        level = SocietyLevel.Medium;
                        Console.WriteLine($"Society level is now: {level}!");
                        break;

                    case 3:
                        level = SocietyLevel.Advanced;
                        Console.WriteLine($"Society level is now: {level}! You have now reached peak society!");
                        break;
                }
            }

            try
            {
                Console.WriteLine("Press 1 to build a hospital, 2 for a military, 3 for a university, or 4 to build a new government");
                int count = int.Parse(Console.ReadLine());

                switch (count)
                {
                    case 1:
                        IInstituition hospitalInst = GovFactory.Build(count);
                        hospitalInst.Establish();
                        CheckLevel(createdInstList.Count);
                        hospitalInst.GetCost();
                        break;


                    case 2:
                        IInstituition militaryInst = GovFactory.Build(count);
                        militaryInst.Establish();
                        CheckLevel(createdInstList.Count);
                        militaryInst.GetCost();
                        break;


                    case 3:
                        IInstituition universityInst = GovFactory.Build(count);
                        universityInst.Establish();
                        CheckLevel(createdInstList.Count);
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
                Console.WriteLine($"Wrong data type. Try again! {e}");
            }

            catch (Exception e)
            {
                Console.WriteLine($"{e}\n\n");
            }
        }
    }
}