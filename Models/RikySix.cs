namespace WebWomen.Models
{
    public class RikySix
    {
        // Constructor with one string argument
        public RikySix(string name)
        {
            Console.WriteLine("Constructor with one argument - String: " + name);
        }

        // Constructor with two arguments
        public RikySix(string name, int age)
        {
            Console.WriteLine("Constructor with two arguments: String and Integer: " +
                              name + " " + age);
        }

        // Constructor with one long argument
        public RikySix(long id)
        {
            Console.WriteLine("Constructor with one argument - Long: " + id);
        }
    }
}
