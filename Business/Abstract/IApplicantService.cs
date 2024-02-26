using Entities.Concrate;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);
        List<Person> GetList();
        bool CheckPerson(Person person);       
    }
}
