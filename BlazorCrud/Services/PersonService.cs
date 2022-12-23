using BlazorCrud.Models;

namespace BlazorCrud.Services
{
    public class PersonService : IPersonService
    {
        private readonly DatabaseContext _ctx;
        public PersonService(DatabaseContext ctx)
        {
            _ctx = ctx;
        }
        public bool AddUpdate(Person person)
        {
            try
            {
                if (person.Id == 0)
                    _ctx.Person.Add(person);
                else
                    _ctx.Person.Update(person);
                _ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var person = FindById(id);
                if (person == null)
                    return false;
                _ctx.Person.Remove(person);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public Person FindById(int id)
        {
            return _ctx.Person.Find(id);
        }

        public List<Person> GetAll()
        {
            return _ctx.Person.ToList();
        }
    }
}
