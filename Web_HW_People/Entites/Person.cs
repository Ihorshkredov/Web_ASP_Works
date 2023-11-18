using System.ComponentModel.DataAnnotations;

namespace Web_HW_People.Entites
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }
    }
}
