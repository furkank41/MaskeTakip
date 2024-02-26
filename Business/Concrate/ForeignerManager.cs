using Business.Abstract;
using Entities.Concrate;

namespace Business.Concrate
{
    public class ForeignerManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
        }

        public bool CheckPerson(Person person)
        {
            return true;
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}
