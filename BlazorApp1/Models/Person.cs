namespace BlazorApp1.Models;

public class Person
{
    public int Id { get; }
    public string Name { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public int Age {  get; set; }


    public Person(int id, string name, string firstName, int age)
    {
        Id = id;
        Name = name;
        FirstName = firstName;
        Age = age;
    }
}
