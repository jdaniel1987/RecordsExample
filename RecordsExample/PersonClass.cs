namespace RecordsExample;

public class PersonClass
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; init; }

    public PersonClass(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}
