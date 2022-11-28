namespace myPeopleApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? PersonName { get; set; }
        public string? PhoneNumber { get; set; }

        public Person(string? personName, string? phoneNumber)
        {
            PersonName = personName;
            PhoneNumber = phoneNumber;
        }
    }
}
