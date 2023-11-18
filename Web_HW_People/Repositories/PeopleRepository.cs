using Web_HW_People.Entites;

namespace Web_HW_People.Repositories
{
    public class PeopleRepository
    {
        private readonly PeopleContext context;

        public PeopleRepository()
        {
            context = new PeopleContext();
        }

        public List<Person> GetPeople()
        {
            return context.People.ToList();
        }
    }
}
