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

            // // for loop begins when x=1 and runs till x <= 4
            for ( x = 1; x <= 4; x++)
                entryloopvals.Add("for loop RikyMac");


            // Exit Controlled Loops

            x = 21;

            do
            {
                // The line will be printed even if the condition is false
                entryloopvals.Add("do-while RikyMac");
                x++;
            }
            while (x < 20);


            //  Nested Loops

            // loop within loop printing 
            for (int i = 2; i < 3; i++)
                for (int j = 1; j < i; j++)
                    entryloopvals.Add("nested loop RikyMac");

            // Continue Statement 

            //  printed only 1 times
            for (int i = 1; i < 3; i++)
            {
                if (i == 2)
                    continue;

                entryloopvals.Add("continue statement RikyMac");
            }


            //foreach Loop
            string[] names = { "Alfred", "RikyMac", "Annie" };

            foreach (string name in names)
            {
                entryloopvals.Add("foreach Name: " + name);
            }


            //Off-by-One Errors
            for (int i = 0; i <= 5; i++)
            {
                entryloopvals.Add("Off-by-One Error: " + i);
             }



            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    // Modifies the loop variable
                    // and skips the next iteration
                    i++;
                }

                entryloopvals.Add("modifies var " + i);
            }

            for (int i = 0; i < 10; i++)
            {
                // Empty body - no operations
            }

            return entryloopvals;
        }


    }
}
