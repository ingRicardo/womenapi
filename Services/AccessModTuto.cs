using WebWomen.Models;
using System;
namespace WebWomen.Services
{

    class Car
    {
        internal string model = "Tesla";
    }

    class Vehicle
    {
        protected internal int speed = 80;
    }


    class VehicleMod
    {
        private protected int speed = 60;
    }

    class BikeMod : VehicleMod
    {
        public string ShowSpeed()
        {

           return speed.ToString();
        }
    }



    public class AccessModTuto
    {
        /*
         * Access modifiers are used to control the visibility and accessibility 
         * of classes, methods, and variables. They help implement encapsulation by 
         * restricting access to different parts of a program. C# provides several access modifiers to define access levels.
         * 
         */

        public static List<Object> GetExamples() {
            List<Object> examples = new List<Object>();

            //Private Access Modifier : Accessible only within the containing type.
            Person p = new Person();
            p.SetName("Alice");
            // Console.WriteLine(p.name); // Error
            examples.Add(p.GetName());

            //Internal Access Modifier : Accessible only within the same assembly.
            Car c = new Car();
            examples.Add(c.model);

            //Protected Access Modifier : Accessible within the containing class and derived classes.
            Bike b = new Bike();
            examples.Add(b.ShowSpeed());

            //Public Access Modifier : Accessible from anywhere the containing type is accessible.
            examples.Add(MathUtils.Add(5, 10));

            //Protected Internal Access Modifier : Accessible within the same assembly or from derived classes in another assembly.
            Vehicle v = new Vehicle();
            examples.Add(v.speed);

            //Private Protected Access Modifier :Accessible within the containing type and derived classes in the same assembly.
            BikeMod bn = new BikeMod();
            examples.Add(bn.ShowSpeed());

            return examples;
        }
  
    }
}
