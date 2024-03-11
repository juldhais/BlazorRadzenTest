using Bogus;

namespace BlazorRadzenTest.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string City { get; set; }


    private static readonly Faker<User> UserFaker = new Faker<User>()
    .RuleFor(x => x.Id, x => x.IndexFaker + 1)
    .RuleFor(x => x.FirstName, x => x.Person.FirstName)
    .RuleFor(x => x.LastName, x => x.Person.LastName)
    .RuleFor(x => x.BirthDate, x => DateOnly.FromDateTime(x.Person.DateOfBirth))
    .RuleFor(x => x.Phone, x => x.Person.Phone)
    .RuleFor(x => x.Email, x => x.Person.Email)
    .RuleFor(x => x.Address, x => x.Person.Address.Street)
    .RuleFor(x => x.City, x => x.Person.Address.City);

    public static List<User> GetAll(int count = 20)
    {
        var response = UserFaker.Generate(count);
        return response;
    }
}
