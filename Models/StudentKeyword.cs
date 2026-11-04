namespace WebWomen.Models
{
    public class StudentKeyword
    {
        int id;
        string name;

        public StudentKeyword(int id, string name)
        {

            this.id = id;
            this.name = name;
        }

        public String Display()
        {
            return "ID: " + this.id + ", Name: " + this.name;
        }

    }
}
