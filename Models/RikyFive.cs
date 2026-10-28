namespace WebWomen.Models
{
    public class RikyFive
    {
        // Private constructor
        private RikyFive()
        {
            Console.WriteLine("Private constructor called");
        }

        public static string DisplayMessage()
        {
            return "Hello from RikyFive class!";
        }
    }
}
