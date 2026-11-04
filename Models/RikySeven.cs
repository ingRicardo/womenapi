namespace WebWomen.Models
{
    public class RikySeven
    {
        public RikySeven() : this(10, 20)
        {
            Console.WriteLine("Inside default constructor");
        }

        public RikySeven(int a, int b)
        {
            Console.WriteLine("Inside parameterized constructor");
            Console.WriteLine("a = " + a + "  b = " + b);
        }
    }
}
