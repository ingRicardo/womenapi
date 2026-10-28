namespace WebWomen.Models
{
    public class RikyOne
    {
        string name;
        int id;

        // Parameterized Constructor
        public RikyOne(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        // Method to display object data
        public string Display()
        {
            return "Name: " + name + " and Id: " + id;
        }
    }
}
