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
        var government = GovSingleton.GetInstance();

        while (running)
        {
            var instituitions = new List<IInstituition>();

            switch(instituitions.Count())
            {
                // Finish this!
                    
            }

        instPropmt:
            try
            {
                Console.WriteLine("Press 1 to build a hospital, 2 for a military, 3 for a university, or 4 to build a new government");
                int count = int.Parse(Console.ReadLine());

                switch (count)
                {
                    case 1:
                        IInstituition hospitalInst = GovFactory.build(count);
                        instituitions.Add(hospitalInst);
                        hospitalInst.Establish();
                        hospitalInst.GetCost();
                        break;


                    case 2:
                        IInstituition militaryInst = GovFactory.build(count);
                        instituitions.Add(militaryInst);
                        militaryInst.Establish();
                        militaryInst.GetCost();
                        break;


                    case 3:
                        IInstituition universityInst = GovFactory.build(count);
                        instituitions.Add(universityInst);
                        universityInst.Establish();
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
                goto instPropmt;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}