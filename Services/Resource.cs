namespace WebWomen.Services
{

    /*
     * 
     * A destructor is a special member of a class that is called during finalization by the garbage collector.
     * It is used to perform cleanup operations before an object is reclaimed.
     */
    public class Resource
    {
        public Resource()
        {
            Console.WriteLine("Resource acquired.");
        }

        // Destructor
        ~Resource() { Console.WriteLine("Destructor called."); }
    }
}
