namespace WebWomen.Models
{
    public class StudentStatic
    {
        int rollNo;
        string name;

        // Static variable
        public static string TrainingCenter = "RAM";

        public StudentStatic(int r, string n)
        {
            rollNo = r;
            name = n;
        }

        public string Display()
        {
            return rollNo + " " + name + " " + TrainingCenter;
        }
    }
}
