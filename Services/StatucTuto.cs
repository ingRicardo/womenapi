using WebWomen.Models;

namespace WebWomen.Services
{
    public class StatucTuto
    {
        public static string exampleStatic()
        {
            
            StudentStatic s1 = new StudentStatic(101, "Ravi");
            StudentStatic s2 = new StudentStatic(102, "Amit");

            s1.Display();
            s2.Display();

            return s1.Display() + ", " + s2.Display();

        }
    }
}
