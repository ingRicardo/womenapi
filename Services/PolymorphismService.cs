using System.Numerics;

namespace WebWomen.Services
{
    class Helper
    {

        // Method with two integer parameters
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method with two double parameters
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
    }



    // Base class
    class Parent
    {
        public virtual void Print()
        {
            Console.WriteLine("parent class");
        }
    }

    // Derived class 1
    class Subclass1 : Parent
    {
        public override void Print()
        {
            Console.WriteLine("subclass1");
        }
    }

    // Derived class 2
    class Subclass2 : Parent
    {
        public override void Print()
        {
            Console.WriteLine("subclass2");
        }
    }


    public class PolymorphismService
    {
        /*
         * Polymorphism is one of the fundamental concepts of Object-Oriented Programming (OOP) that
         * allows a common interface or method name to represent different behaviors.
         * It enables methods to behave differently based on the arguments supplied or 
         * the actual object type, improving code flexibility and reusability.
         */


        public static List<Object> getPolyObj()
        {
            List<Object> polyObj = new List<Object>();

            //1. Compile Time Polymorphism
            polyObj.Add("Compile Time Polymorphism");
            polyObj.Add(Helper.Multiply(2, 4)); // Calls the integer version
            polyObj.Add(Helper.Multiply(5.5, 6.3)); // Calls the double version

            //2. Runtime Polymorphism
            polyObj.Add("Runtime Polymorphism");
            Parent a;

            a = new Subclass1();
            a.Print();

            a = new Subclass2();
            a.Print();


            return polyObj;
        }

    }
}
