namespace WebWomen.Models
{
    public class C3W
    {
        private int r;

        public int RollNo
        {
            get { return r; }
            set { r = value; }
        }

        public C3W(int rollNo)
        {
            RollNo = rollNo;
        }
    }
}
