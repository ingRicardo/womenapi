namespace WebWomen.Services
{

    abstract class VehicleAb
    {

        // Abstract method
        public abstract void Start();
    }

    // Derived class
    class CarAb : VehicleAb
    {
        public override void Start()
        {
            Console.WriteLine(
                "Car starts with a key or button.");
        }
    }

    abstract class Shape
    {

        public abstract void Area();
    }

    class Circle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of Circle: "
                              + (3.14 * 5 * 5));
        }
    }


    interface IShape
    {

        void Area();
    }

    class Rectangle : IShape
    {

        public void Area()
        {
            Console.WriteLine("Area of Rectangle: " + (4 * 5));
        }
    }


    public class AbstractionService
    {
        public static List<string> AbstractionExample()
        {
            List<string> lt = new List<string>();
            VehicleAb vehicle = new CarAb();
            vehicle.Start();
            
            lt.Add("Abstraction example executed successfully.");

            Shape shape = new Circle();
            shape.Area();

            lt.Add("1. Abstraction Using Abstract Classes");

            IShape shapeIn = new Rectangle();
            shapeIn.Area();

            lt.Add("2. Abstraction Using Interfaces");


            return lt;
        }

    }
}
