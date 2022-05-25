using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonalModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonalModel { Id = 1, FirstName = "Behrouz", LastName = "Talavari" });
            people.Add(new PersonalModel { Id = 2, FirstName = "Mehrdad", LastName = "Shokouhinia" });
        }

        public List<PersonalModel> GetPeople()
        {
            return people;
        }
        public PersonalModel InsertPerson(string firstName, string lastName)
        {
            PersonalModel p = new() { LastName = lastName, FirstName = firstName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }
    }
}
