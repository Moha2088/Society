using Societygame.Products;
using SocietyGame.Interfaces;

namespace Societygame.Factory;

public class GovFactory
{

    public GovFactory() { }


    public static IInstituition Build(int instituition)
    {
        switch (instituition)
        {
            case 1:
                var hospitalInstituition = new HospitalInstituition();
                return hospitalInstituition;

            case 2:
                var militaryInsituition = new MilitaryInstituition();
                return militaryInsituition;

            case 3:
                var universityInsituition = new UniversityInstituition();
                return universityInsituition;

            default:
                throw new NotSupportedException("This instituition is not supported!");
        }
    }
}