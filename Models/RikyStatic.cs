namespace WebWomen.Models
{
    public class RikyStatic
    {
        public static int a;
        public static int b;

        static RikyStatic()
        {
            Console.WriteLine("Static constructor executed.");
            a = 10;
            b = a * 4;
        }
    }
}
