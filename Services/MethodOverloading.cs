namespace WebWomen.Services
{
    public class MethodOverloading
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }


        public string StudentId(string name, int rollNo)
        {
            return "Name: " + name + ", Roll-No: " + rollNo;
        }

        public string StudentId(int rollNo, string name)
        {
            return "Roll-No: " + rollNo + ", Name: " + name;
        }


        public string Show(int x)
        {
            return "In int: " + x;
        }

        public string Show(string s)
        {
            return "In String: " + s;
        }

        public string Show(byte b)
        {
            return "In byte: " + b;
        }

    }

}
