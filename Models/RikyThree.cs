namespace WebWomen.Models
{
    public class RikyThree
    {
        public string name;
        public int id;

        // Parameterized Constructor
        public RikyThree(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        // Copy Constructor
        public RikyThree(RikyThree obj)
        {
            this.name = obj.name;
            this.id = obj.id;
        }
    }
}
