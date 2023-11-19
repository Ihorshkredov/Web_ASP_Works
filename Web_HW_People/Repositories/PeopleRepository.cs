using Web_HW_People.Entites;
using Web_HW_People.Models;

namespace Web_HW_People.Repositories
{
    public class PeopleRepository
    {
        private readonly PeopleContext context;

        public PeopleRepository()
        {
            context = new PeopleContext();
        }

        public List<Personage> GetPeople()
        {
           var entitiesFromDb = context.People.ToList();
            return
                entitiesFromDb.Select(e => new Models.Personage
                {
                    FirstName = e.FirstName,
                    Surname = e.Surname,
                    Email = e.Email,
                    Age = e.Age,

                }).ToList();
        }
    }
}
