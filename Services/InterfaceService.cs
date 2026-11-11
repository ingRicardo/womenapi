namespace WebWomen.Services
{
    //Interface
    // Declare an interface
    interface IAnimal
    {

        string Sound(); 
    }

    // Implement the interface
    class DogInter : IAnimal
    {

        public string Sound() { 
            //Console.WriteLine("Dog barks"); 
            return "Dog barks";
        }
    }

    //Multiple Interfaces

    // First interface
    interface IPrintable
    {

        string Print();
    }

    // Second interface
    interface IScannable
    {

        string Scan();
    }

    // Implement multiple interfaces
    class Printer : IPrintable, IScannable
    {

        public string Print()
        {

            //Console.WriteLine("Printing document");
            return "Printing document";
        }

        public string Scan()
        {

            //Console.WriteLine("Scanning document");
            return "Scanning document";
        }
    }


    //Interface Inheritance

    // Base interface
    interface IAnimalint
    {
        string Eat();
    }

    // Derived interface
    interface IDog : IAnimalint
    {
        string Bark();
    }

    // Implement derived interface
    class DogI : IDog
    {

        public string Eat()
        {

            //Console.WriteLine("Dog is eating");
            return "Dog is eating";
        }

        public string Bark()
        {

            //Console.WriteLine("Dog is barking");
            return "Dog is barking";
        }
    }

    //Default Interface Methods

    interface IMessage
    {

        // Default interface method
        string Show()
        {
            //Console.WriteLine("Default Message");
            return "Default Message";
        }
    }

    class Message : IMessage
    {

        // Uses the default implementation
    }

    public class InterfaceService
    {
        public static List<string> GetInterfaceService()
        {
            List<string> list = new List<string>();
            // Create an object of Dog
            DogInter dog = new DogInter();
            // Call the implemented method
            string dogSound = dog.Sound();

            list.Add("Interface Service Called");
            list.Add(dogSound);

            // Create an object of Printer
            Printer printer = new Printer();

            list.Add("Multiple Interfaces - Printer Service Called");
            // Call interface methods
            list.Add(printer.Print());
            list.Add(printer.Scan());


            // Create Dog object
            DogI dogIn = new DogI();

            list.Add("Interface Inheritance - Dog Service Called");
            //dogIn.Eat();
            list.Add(dogIn.Eat());
            //dogIn.Bark();
            list.Add(dogIn.Bark());

            list.Add("Default Interface Methods - Message Service Called");
            // Access through interface reference
            IMessage msg = new Message();
            list.Add(msg.Show());

            return list;
        }
    }
}
