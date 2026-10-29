namespace WebWomen.Services
{
    public class ResourceOne : IDisposable
    {
        public ResourceOne()
        {
            Console.WriteLine("ResourceOne acquired.");
        }

        public void Dispose()
        {
            Console.WriteLine("ResourceOne released.");
        }
    }
}
