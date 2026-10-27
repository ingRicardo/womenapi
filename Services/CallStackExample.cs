namespace WebWomen.Services
{
    public class CallStackExample
    {
        public static void D()
        {

            float d = 40.5f;
            Console.WriteLine("In Method D: " + d);
        }

        public static void C()
        {

            double c = 30.5;
            Console.WriteLine("In Method C: " + c);
        }

        public static void B()
        {

            int b = 20;
            C(); // Calling C
            Console.WriteLine("In Method B: " + b);
        }

        public static void A()
        {

            int a = 10;
            B(); // Calling B
            Console.WriteLine("In Method A: " + a);
        }

    }
}
