namespace WebWomen.Services
{
    public class RikyClass : Rikyshelp
    {
        public override void Check(string name)
        {
            if (name == "Riky")
            {
                Console.WriteLine("Hello Riky");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }
        }
    }
}
