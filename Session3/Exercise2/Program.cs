using Exercise2;

public class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new()
        {
            Firstname = "Marija",
            Lastname = "P",
            Age = 11,
            Height = 180.5,
            IsMarried = false,
            Sex = 'f',
            Hobbies = new string[] { "porn", "football" }
        };
    }
}