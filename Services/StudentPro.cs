namespace WebWomen.Services
{
    public class StudentPro
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Age cannot be negative!");
            }
        }
    }
}
