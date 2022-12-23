using BlazorCrud.Models;

namespace BlazorCrud.Services
{
    public interface IPersonService
    {
        bool AddUpdate(Person person);
        bool Delete(int id);
        Person FindById(int id);
        List<Person> GetAll(); 
    }
}
