using Microsoft.EntityFrameworkCore;

namespace Web_HW_People.Entites

{
    public class PeopleContext: DbContext
    {
        public PeopleContext()
        {
            Database.EnsureCreated();

            var person1 = new Person()
            {
                FirstName = "Ker",
                Surname = "Laeda",
                Email = "kerlaed@gmail.com",
                Age = 124
            };
            var person2 = new Person()
            {
                FirstName = "Hedin",
                Surname = "Light",
                Email = "hedin@ukr.net",
                Age = 2309
            };
            var person3 = new Person()
            {
                FirstName = "Rakot",
                Surname = "Dark",
                Email = "rakotthedark@gmail.com",
                Age = 2308
            };
            var person4 = new Person()
            {
                FirstName = "Gerald",
                Surname = "Rivvian",
                Email = "witcher@pol.com",
                Age = 38
            };

            People.Add(person1);
            People.Add(person2);
            People.Add(person3);
            People.Add(person4);

            SaveChanges();
            
                
        }
        public DbSet<Person> People { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database = PeopleWebMVC; Trusted_Connection = True; TrustServerCertificate = True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
