using Microsoft.AspNetCore.Mvc;
using Web_HW_People.Models;
using Web_HW_People.Repositories;

namespace Web_HW_People.Controllers
{
    public class PersonController : Controller
    {
        private PeopleRepository personRepository; 
        public PersonController()
        {
            personRepository = new PeopleRepository();    
        }

        public ActionResult<List<Personage>> Index() 
        {
            var result = personRepository.GetPeople();
            return View(result);
        }

        public ActionResult<Personage> WitcherIntro() 
        {
            var result = personRepository.GetPeople().Where(p => p.FirstName == "Gerald").FirstOrDefault();
            return View(result);
        }
    }
}
