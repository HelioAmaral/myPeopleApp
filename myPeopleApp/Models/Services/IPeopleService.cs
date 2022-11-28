using myPeopleApp.Models.ViewModels;

namespace myPeopleApp.Models.Services
{
    public interface IPeopleService
    {
        Person Create(CreatePersonViewModel createPerson);
        List<Person> GetAll();
        Person FindById(int id);
        bool Edit(int id, CreatePersonViewModel editPerson);
        bool Delete(int id);
        
    }
}
