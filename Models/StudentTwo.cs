namespace WebWomen.Models
{
    public class StudentTwo
    {
        private int rollNo;

        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        public StudentTwo(int rollNo)
        {
            this.RollNo = rollNo;
        }
    }
}
