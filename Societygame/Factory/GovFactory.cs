using Societygame.Products;
using SocietyGame.Interfaces;
using SocietyGame.Enums;

namespace Societygame.Factory;

public class GovFactory
{
    public static List<IInstituition> instituitions = [];

    public static SocietyLevel level;


    public GovFactory() { }

    public static IInstituition Build(int instituition)
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