using System.Collections.Generic;

namespace WpfDataBindingWithListToClass;

public class Persons
{
    public static List<Person> GetPersons()
    {
        return new List<Person>()
        {
            new Person() { Name = "John", Age = 20 },
            new Person() { Name = "Jane", Age = 30 },
            new Person() { Name = "Jany", Age = 40 }
        };
    }
}