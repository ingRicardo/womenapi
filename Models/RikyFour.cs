namespace WebWomen.Models
{
    public class RikyFour
    {
        static RikyFour()
        {
            Console.WriteLine("Static constructor called");
        }

        public static string DisplayMessage()
        {
            return "Hello from RikyFour class!";
        }
    }
}
