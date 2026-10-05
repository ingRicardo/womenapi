namespace WebWomen.Services
{
    public class Entryloops
    {

        public List<Object> EntryLoops()
        {

            List<Object> entryloopvals = new List<Object>();


            int x = 1;

            // Exit when x becomes greater than 4
            while (x <= 4)
            {
                entryloopvals.Add("while RikyMac");

                // Increment the value of x for next iteration
                x++;
            }

            return entryloopvals;
        }


    }
}
