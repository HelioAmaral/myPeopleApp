namespace myPeopleApp.Models.Repos
{
    public interface IPeopleRepo
    {
        Person Create(Person person);
        List<Person> GetAll();
        Person GetById(int id);
        bool Update(Person person);
        bool Delete(Person person);
    }
}
