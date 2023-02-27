
using System.Text.Json;
using Exercise1;

public class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new()
        {
            Firstname = "Jack",
            Lastname = "Spine",
            Age = 11,
            Height = 180.5,
            IsMarried = false,
            Sex = 'f',
            Hobbies = new string[] { "porn", "football" }
        };
        
        Person p2 = new()
        {
            Firstname = "Kris",
            Lastname = "LovesDani",
            Age = 10,
            Height = 180,
            IsMarried = false,
            Sex = 'f',
            Hobbies = new string[] { "porn", "football" }
        };
        Person p3 = new()
        {
            Firstname = "G",
            Lastname = "LovesDani",
            Age = 10,
            Height = 180,
            IsMarried = false,
            Sex = 'f',
            Hobbies = new string[] { "porn", "football" }
        };

        List<Person> p = new List<Person>(){p1, p2, p3};
        string pAsJson = JsonSerializer.Serialize(p);
        

        Console.WriteLine(pAsJson);
    }
}