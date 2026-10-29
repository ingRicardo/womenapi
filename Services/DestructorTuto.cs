namespace WebWomen.Services
{
    public class DestructorTuto
    {

        public static List<Object> destructorcall()
        {
            Resource resource = new Resource();
            List<Object> messages = new List<Object>();
            messages.Add("DESTRUCTORS");
            messages.Add("Using the resource.");
            Console.WriteLine("Using the resource.");
            Console.WriteLine("----------------");
            //IDisposable and using Statement
            messages.Add("IDisposable and using Statement");
            using (ResourceOne resourceone = new ResourceOne())
            {
                messages.Add("Using the ResourceOne.");
                Console.WriteLine("Using the ResourceOne.");
            }

            messages.Add("End of program.");
            Console.WriteLine("End of program.");
            return messages;
        }
    }
}
