using Societygame.Products;
using SocietyGame.Interfaces;

namespace Societygame.Factory;

public class GovFactory
{
    public GovFactory() { }

    public static List<IInstituition> instituitionsCreated = new List<IInstituition>();


    public static event Action? MaxCountReached;

    public delegate void DuplicateDetectedHandler(IInstituition instituition);
    public static event DuplicateDetectedHandler? DuplicateDetected;



    static void InvokeIfDuplicate(IInstituition createdInst)
    {
        if (instituitionsCreated.Any(inst => inst.GetType() == createdInst.GetType()))
        {
            DuplicateDetected?.Invoke(createdInst);
        }
    }

    public static IInstituition Build(int instituition)
    {
        if (instituitionsCreated.Count == 3) MaxCountReached?.Invoke();

        switch (instituition)
        {
            case 1:
                var hospitalInstituition = new HospitalInstituition();
                InvokeIfDuplicate(hospitalInstituition);
                instituitionsCreated.Add(hospitalInstituition);
                return hospitalInstituition;

            case 2:
                var militaryInsituition = new MilitaryInstituition();
                InvokeIfDuplicate(militaryInsituition);
                instituitionsCreated.Add(militaryInsituition);
                return militaryInsituition;

            case 3:
                var universityInsituition = new UniversityInstituition();
                InvokeIfDuplicate(universityInsituition);
                instituitionsCreated.Add(universityInsituition);
                return universityInsituition;

            default:
                throw new NotSupportedException("This instituition is not supported!");
        }
    }
}