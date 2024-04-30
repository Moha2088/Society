using Societygame.Products;
using SocietyGame.Interfaces;

using SocietyGame.Entities;

namespace Societygame.Factory;

public class GovFactory
{

    public static List<IInstituition> instituitions = [];

    public SocietyLevel level;

    private int _instCount;

    public GovFactory()
    {
        switch (_instCount)
        {
            case 1:
                level = SocietyLevel.Primitive;
                break;

            case 2:
                level = SocietyLevel.Medium;
                break;

            case 3:
                level = SocietyLevel.Advanced;
                break;
        }
    }

    public static IInstituition build(int instituition)
    {
        switch (instituition)
        {
            case 1:
                var hospitalInstituition = new HospitalInstituition();
                instituitions.Add(hospitalInstituition);
                return hospitalInstituition;

            case 2:
                var militaryInsituition = new MilitaryInstituition();
                instituitions.Add(militaryInsituition);
                return militaryInsituition;

            case 3:
                var universityInsituition = new UniversityInstituition();
                instituitions.Add(universityInsituition);
                return universityInsituition;

            default:
                throw new NotSupportedException("This instituition is not supported!");
        }
    }
}