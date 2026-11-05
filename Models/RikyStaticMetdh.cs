namespace WebWomen.Models
{
    public class RikyStaticMetdh
    {
        public static int a = GetValue();

        static RikyStaticMetdh()
        {
            Console.WriteLine("Inside static constructor");
        }

        public static int GetValue()
        {
            Console.WriteLine("From GetValue");
            return 20;
        }

    }
}
